using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace vd1
{
    public partial class Form_NV : Form
    {
        public Form_NV()
        {
            InitializeComponent();
        }
        XmlDocument doc =new XmlDocument();
        string tentep = @"C:\Users\Mr.Duong\Documents\Tích hợp\em dương\PhamThaiDuong_136\PhamThaiDuong_136\vd1\nhanvien.xml";
        int d;
        private void HienThi()
        {
            datanhanvien.Rows.Clear();
            doc.Load(tentep);
            XmlNodeList DS = doc.SelectNodes("/ds/nhanvien");
            int sd = 0;
            datanhanvien.ColumnCount = 3;
            datanhanvien.Rows.Add();
            foreach(XmlNode nhan_vien in DS) 
            {
                XmlNode ma_nv = nhan_vien.SelectSingleNode("@manv");
                datanhanvien.Rows[sd].Cells[0].Value = ma_nv.InnerText.ToString();
                XmlNode ho_ten = nhan_vien.SelectSingleNode("hoten");
                datanhanvien.Rows[sd].Cells[1].Value = ho_ten.InnerText.ToString();
                XmlNode dia_chi = nhan_vien.SelectSingleNode("diachi");
                datanhanvien.Rows[sd].Cells[2].Value = dia_chi.InnerText.ToString();
                datanhanvien.Rows.Add();
                sd++;
            }
        
        }
        private void Form_NV_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;
            XmlNode nhan_vien = doc.CreateElement("nhanvien");
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            ma_nv.InnerText = txt_manv.Text;
            nhan_vien.Attributes.Append( ma_nv );
            XmlNode ho_ten = doc.CreateElement("hoten");
            XmlNode dia_chi = doc.CreateElement("diachi");
            ho_ten.InnerText = txt_hoten.Text;
            dia_chi.InnerText = txt_diachi.Text;
            nhan_vien.AppendChild(ho_ten);
            nhan_vien.AppendChild(dia_chi);
            goc.AppendChild( nhan_vien );
            doc.Save(tentep);
            HienThi();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;
            XmlNode nhan_vien_xoa = goc.SelectSingleNode("/ds/nhanvien[@manv= '" + txt_manv.Text +"']");
            goc.RemoveChild( nhan_vien_xoa );
            doc.Save(tentep);
            HienThi() ;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            doc.Load(tentep) ;
            XmlElement goc = doc.DocumentElement;  
            XmlNode nhan_vien_cu= goc.SelectSingleNode("/ds/nhanvien[@manv='"+txt_manv.Text + "']");
            XmlNode nhan_vien_moi = doc.CreateElement("nhanvien");
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            ma_nv.InnerText = txt_manv.Text;
            nhan_vien_moi.Attributes.Append(ma_nv);

            XmlNode ho_ten = doc.CreateElement("hoten");
            ho_ten.InnerText = txt_hoten.Text;
            nhan_vien_moi.AppendChild( ho_ten );

            XmlNode dia_chi = doc.CreateElement("diachi");
            dia_chi.InnerText = txt_hoten.Text;
            nhan_vien_moi.AppendChild(dia_chi);

            goc.ReplaceChild(nhan_vien_moi, nhan_vien_cu);
            doc.Save(tentep);
            HienThi();
        }

        private void datanhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            txt_manv.Text = datanhanvien.Rows[d].Cells[0].Value.ToString();
            txt_hoten.Text = datanhanvien.Rows[d].Cells[1].Value.ToString();
            txt_diachi.Text = datanhanvien.Rows[d].Cells[2].Value.ToString();
        }

        private void bt_Tim_Click(object sender, EventArgs e)
        {
            
        }
    }
}
