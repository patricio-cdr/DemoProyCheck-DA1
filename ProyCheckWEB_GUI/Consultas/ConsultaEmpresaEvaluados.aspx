<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="ConsultaEmpresaEvaluados.aspx.cs" Inherits="ProyCheckWEB_GUI.Consultas.WebEmpresaEvaluados" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 141px;
            font-size: 12pt;
        }
        .auto-style3 {
            font-family: Verdana;
            font-size: 11pt;
        }
        .auto-style4 {
            width: 141px;
            font-size: 12pt;
            height: 33px;
        }
        .auto-style5 {
            height: 33px;
        }
        .auto-style6 {
            width: 141px;
            font-size: 12pt;
            height: 30px;
        }
        .auto-style7 {
            height: 30px;
        }
        </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Consulta empresas por ubicación</h1>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Departamento:</td>
            <td>
                <ajaxToolkit:ComboBox ID="cboDepartamento" runat="server">
                </ajaxToolkit:ComboBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Provincia:</td>
            <td class="auto-style7">
                <ajaxToolkit:ComboBox ID="cboProvincia" runat="server">
                </ajaxToolkit:ComboBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Distrito:</td>
            <td class="auto-style5">
                <ajaxToolkit:ComboBox ID="cboDistrito" runat="server">
                </ajaxToolkit:ComboBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="btn" OnClick="btnConsultar_Click" Height="39px" />
            </td>
        </tr>
    </table>
        <asp:GridView ID="grvEmpEvaluados" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style3" GridLines="None" AllowPaging="True" Width="1109px" ForeColor="#333333" PageSize="11">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="codEmpresa" HeaderText="Código" />
                <asp:BoundField DataField="raz_soc_emp" HeaderText="Razón social" />
                <asp:BoundField DataField="Ruc_emp" HeaderText="RUC" />
                <asp:BoundField DataField="Años_servicios" HeaderText="Años de servicio" />
                <asp:BoundField DataField="Estado_actual" HeaderText="Estado actual" />
                <asp:BoundField DataField="Id_Ubigeo" HeaderText="Ubigeo" />
                <asp:BoundField DataField="Departamento" HeaderText="Departamento" />
                <asp:BoundField DataField="Provincia" HeaderText="Provincia" />
                <asp:BoundField DataField="Distrito" HeaderText="Distrito" />
                <asp:BoundField ConvertEmptyStringToNull="False" DataField="Trabajadores_Evaluados" HeaderText="Trabajadores evaluados" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">Retornar</asp:HyperLink>
<br />
<br />
<asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>

</asp:Content>
