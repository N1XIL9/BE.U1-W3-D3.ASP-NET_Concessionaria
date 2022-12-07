<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BE.U1_W3_D3.ASP_NET_Concessionaria.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="style.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div class="container cont-drop">
            <h1>CONFIGURA LA TUA AUTO</h1>
            <div class="row ">
                <div class="col-6">
                    <asp:DropDownList ID="DropDownAuto" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownAuto_SelectedIndexChanged"
                         CssClass="FormControl">
                        <asp:ListItem Value="0" Text=""></asp:ListItem>
                        <asp:ListItem Value="125450" Text="McLaren 765 LT"></asp:ListItem>
                        <asp:ListItem Value="222980" Text="Porsche 911 GT3"></asp:ListItem>
                        <asp:ListItem Value="123600" Text="McLaren 600 LT"></asp:ListItem>
                        <asp:ListItem Value="251600" Text="Ferrari 488 Pista"></asp:ListItem>
                        <asp:ListItem Value="816900" Text="Lamborghini Aventador SVJ"></asp:ListItem>
                        <asp:ListItem Value="28500" Text=""></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-6">
                    <div class="card" style="width: 18rem;">
                        <asp:Image ID="Image1" runat="server" />
                        <div class="card-body">
                             <asp:Label ID="lblDescrAuto" runat="server" Text=""></asp:Label>
                             <hr />
                             <asp:Label ID="PrezzoBase" Font-Bold="true" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <hr />
        <div class="container">
            <h3>OPTIONAL</h3>
            <div class="row text-center">
                <div>
                    <asp:CheckBoxList ID="cblOptional" CssClass="form-control" RepeatColumns="3" runat="server">
                        <asp:ListItem Text="Vernice metallizzata nera (+ 1250,00 €)" Value="250"></asp:ListItem>
                        <asp:ListItem Text="Vernice metallizzata gialla (+ 3450,00 €)" Value="250"></asp:ListItem>
                        <asp:ListItem Text="Vernice metallizzata verde (+ 4250,00 €)" Value="250"></asp:ListItem>
                 
                        <asp:ListItem Text="Vernice opaca nera (+ 2250,00 €)" Value="250"></asp:ListItem>
                        <asp:ListItem Text="Vernice opaca bianca (+ 3250,00 €)" Value="250"></asp:ListItem>
                        <asp:ListItem Text="Vernice opaca grigio (+ 5250,00 €)" Value="250"></asp:ListItem>
                        </asp:CheckBoxList>
                </div>
            </div>
        </div>
        <hr />
         <div class="container cont-garanz">
            <h3>SCEGLI IL PERIODO DI GARANZIA</h3>
            <div class="row">
                <div class="col-4">
                    <asp:DropDownList ID="ddlGaranzia" runat="server"
                         CssClass="FormControl">
                        <asp:ListItem Value="1" Text="1 anno"></asp:ListItem>
                        <asp:ListItem Value="2" Text="2 anni"></asp:ListItem>
                        <asp:ListItem Value="3" Text="3 anni"></asp:ListItem>
                        <asp:ListItem Value="4" Text="4 anni"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
        </div>
        <div id="Configurazione" runat="server">
            <asp:Label ID="ListaConfig" runat="server" Text=""></asp:Label>
            <asp:Label ID="TotConfig" Font-Bold="true" ForeColor="CadetBlue" Font-Size="28px" runat="server" Text=""></asp:Label>
        </div>
        <div class="container con-btn">
            <div>
                <asp:Button ID="Button1" runat="server" Text="Calcola preventivo" onclick="Button1_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
