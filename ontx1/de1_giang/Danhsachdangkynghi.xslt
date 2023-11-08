<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<body>
				<h1>DANH SÁCH ĐĂNG KÝ NGHỈ</h1>
				<xsl:apply-templates select="/dangkynghi/ngaylamviec"/>
			</body>
		</html>
		
    </xsl:template>
	<xsl:template match="ngaylamviec">
		Ngày làm việc: <xsl:value-of select="@ngay"/>
		<table border="1">
			<tr style="background:green">
				<th>STT</th>
				<th>Mã NV</th>
				<th>Lý do</th>
				<th>Đơn vị</th>
				<th>Trạng thái</th>
			</tr>
			<xsl:apply-templates select="nhanvien"/>
		</table>
	</xsl:template>
	<xsl:template match="/dangkynghi/ngaylamviec/nhanvien">
		<tr>
			<td>
				<xsl:value-of select="position()"/>
			</td>
			<td>
				<xsl:value-of select="@manv"/>
			</td>
			<td>
				<xsl:value-of select="lydo"/>
			</td>
			<td>
				<xsl:value-of select="donvi"/>
			</td>
			<xsl:if test="trangthai = 'Chờ phê duyệt'">
				<td style="background:yellow">
					<xsl:value-of select="trangthai"/>
				</td>
			</xsl:if>
			<xsl:if test="trangthai != 'Chờ phê duyệt'">
				<td >
					<xsl:value-of select="trangthai"/>
				</td>
			</xsl:if>
		</tr>
	</xsl:template>
</xsl:stylesheet>
