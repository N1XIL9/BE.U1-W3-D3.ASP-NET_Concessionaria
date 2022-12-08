using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE.U1_W3_D3.ASP_NET_Concessionaria
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Configurazione.Visible = false;
        }

        public class Auto
        {
            public string Modello { get; set; }
            public string Optional { get; set; }
            public string Garanzia { get; set; }

        }

        
        protected void DropDownAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AutoScelta = DropDownAuto.SelectedItem.Text;
            Double Prezzo = Convert.ToDouble(DropDownAuto.SelectedItem.Value);

            if (AutoScelta == "McLaren 765 LT")
            {
                Image1.ImageUrl = "/img/1.jpg";
                lblDescrAuto.Text = $"Stai configurando: <br /> {AutoScelta}";
                PrezzoBase.Text = $"Prezzo di listino: {Prezzo.ToString("c2")}";
            }
            else if (AutoScelta == "Porsche 911 GT3")
            {
                Image1.ImageUrl = "/img/2.jpg";
                lblDescrAuto.Text = $"Stai configurando: <br /> {AutoScelta} <br />";
                PrezzoBase.Text = $"Prezzo di listino: {Prezzo.ToString("c2")}";
            }
            else if (AutoScelta == "McLaren 600 LT")
            {
                Image1.ImageUrl = "/img/3.jpg";
                lblDescrAuto.Text = $"Stai configurando: <br /> {AutoScelta} <br />";
                PrezzoBase.Text = $"Prezzo di listino: {Prezzo.ToString("c2")}";
            }
            else if (AutoScelta == "Ferrari 488 Pista")
            {
                Image1.ImageUrl = "/img/4.jpg";
                lblDescrAuto.Text = $"Stai configurando: <br /> {AutoScelta} <br />";
                PrezzoBase.Text = $"Prezzo di listino: {Prezzo.ToString("c2")}";
            }
            else if (AutoScelta == "Lamborghini Aventador SVJ")
            {
                Image1.ImageUrl = "/img/5.jpg";
                lblDescrAuto.Text = $"Stai configurando: <br /> {AutoScelta} <br />";
                PrezzoBase.Text = $"Prezzo di listino: {Prezzo.ToString("c2")}";
            }

          
        }


     
        protected void Button1_Click(object sender, EventArgs e)
        {
            Configurazione.Visible = true;

            string optional = "";
            decimal TotOptional = 0;
            double TotOpt = 0;
            double TotMod = 0;
            double Garanzia = Convert.ToDouble(ddlGaranzia.SelectedItem.Value);
            double TotGar = Garanzia * 120;

            foreach (ListItem opt in cblOptional.Items)
            {
                if (opt.Selected)
                {
                    optional += $" - {opt.Text} ";
                    TotOptional += Convert.ToInt32(opt.Value);
                }
            }


            TotOpt = Convert.ToDouble(TotOptional);
            TotMod = Convert.ToDouble(DropDownAuto.SelectedItem.Value);
            double TotCompl = TotMod + TotOpt + TotGar;

            ListaConfig.Text = $"Totale Modello: {TotMod.ToString("c2")}<br />Totale Optional: {TotOpt.ToString("c2")}<br />Totale Garanzia: {TotGar.ToString("c2")}<br />";

            TotConfig.Text = $"Totale Complessivo: {TotCompl.ToString("c2")}";

        }
    }
}