using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//1- XML KÜTÜPHANESİ EKLEDİK
using System.Xml;

namespace ExchangeMoney_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        double e_alis, e_satis, d_satis, d_alis;

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {
            TextBox3.Text = Convert.ToString(double.Parse(TextBox5.Text) / double.Parse(Lbdsatis.Text));
            TextBox4.Text = Convert.ToString(double.Parse(TextBox5.Text) / double.Parse(Lbesatis.Text));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            dovizcek();
        }

        public void dovizcek()
        {
            XmlTextReader oku = new XmlTextReader("https://www.tcmb.gov.tr/kurlar/today.xml"); ;
            XmlDocument belge = new XmlDocument();
            belge.Load(oku);

            XmlNode dolar = belge.SelectSingleNode("/Tarih_Date/Currency[CurrencyName='US DOLLAR']");
            XmlNode euro = belge.SelectSingleNode("/Tarih_Date/Currency[CurrencyName='EURO']");

            d_alis = double.Parse(dolar.ChildNodes[3].InnerText, new System.Globalization.CultureInfo("en-US"));
            d_satis = double.Parse(dolar.ChildNodes[4].InnerText, new System.Globalization.CultureInfo("en-US"));

            e_alis = double.Parse(euro.ChildNodes[3].InnerText, new System.Globalization.CultureInfo("en-US"));
            e_satis = double.Parse(euro.ChildNodes[4].InnerText, new System.Globalization.CultureInfo("en-US"));

            Lbdalis.Text = d_alis.ToString();
            Lbdsatis.Text = d_satis.ToString();
            Lbealis.Text = d_alis.ToString();
            Lbesatis.Text = d_satis.ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //2. OLARAK BURADAKAİ KODLARI YAZIYORUZ
            XmlTextReader oku = new XmlTextReader("https://www.tcmb.gov.tr/kurlar/today.xml"); ;
            XmlDocument belge = new XmlDocument();
            belge.Load(oku);

            XmlNode dolar = belge.SelectSingleNode("/Tarih_Date/Currency[CurrencyName='US DOLLAR']");
            XmlNode euro = belge.SelectSingleNode("/Tarih_Date/Currency[CurrencyName='EURO']");

            d_alis = double.Parse(dolar.ChildNodes[3].InnerText, new System.Globalization.CultureInfo("en-US"));
            d_satis = double.Parse(dolar.ChildNodes[4].InnerText, new System.Globalization.CultureInfo("en-US"));

            e_alis = double.Parse(euro.ChildNodes[3].InnerText, new System.Globalization.CultureInfo("en-US"));
            e_satis = double.Parse(euro.ChildNodes[4].InnerText, new System.Globalization.CultureInfo("en-US"));

            Lbdalis.Text = d_alis.ToString();
            Lbdsatis.Text = d_satis.ToString();
            Lbealis.Text = d_alis.ToString();
            Lbesatis.Text = d_satis.ToString();
        }
    }
}