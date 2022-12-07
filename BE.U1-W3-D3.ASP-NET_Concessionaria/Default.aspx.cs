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

        Auto vettura = new Auto();
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

            vettura.Modello = AutoScelta;

            AggiungiOptonal();
        }


        public void AggiungiOptonal()
        {
            string optional = "";
            decimal TotOptional = 0;

            foreach (ListItem opt in cblOptional.Items)
            {
                if (opt.Selected)
                {
                    optional += $" - {opt.Text}";
                    TotOptional += Convert.ToInt32(opt.Value);
                }
            }
            vettura.Optional = optional;
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string garanzia = ddlGaranzia.SelectedItem.ToString();
            Configurazione.Visible = false;

        }
    }
}