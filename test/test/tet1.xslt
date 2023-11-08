<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<body>
				<xsl:variable name="a" select="/goc/hsa"></xsl:variable>
				<xsl:variable name="b" select="/goc/hsb"></xsl:variable>
				Đáp án của phương trình ax + b là:
				<xsl:if test="$a &lt;8 ">
					<xsl:value-of select="-$b div $a"/>
				</xsl:if>
				
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
