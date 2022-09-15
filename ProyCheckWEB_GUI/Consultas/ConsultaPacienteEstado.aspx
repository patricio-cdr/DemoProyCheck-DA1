<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="ConsultaPacienteEstado.aspx.cs" Inherits="ProyCheckWEB_GUI.Consultas.ConsultaPacienteEstado" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 22px;
        }
        .auto-style5 {
            height: 22px;
            width: 260px;
        }
        .auto-style7 {
            height: 22px;
            width: 367px;
        }
        .auto-style8 {
            width: 260px;
            height: 26px;
        }
        .auto-style9 {
            width: 367px;
            height: 26px;
        }
        .auto-style10 {
            height: 26px;
        }
        .auto-style11 {
            width: 260px;
            height: 30px;
        }
        .auto-style12 {
            width: 367px;
            height: 30px;
        }
        .auto-style13 {
            height: 30px;
        }
        .error{
            color: #ff0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Consulta Estado de Pacientes CheckSalud</h1>
    <table class="auto-style2">
        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label1" runat="server" Text="Tipo de Paciente:"></asp:Label>
            </td>
            <td class="auto-style12">
                <ajaxToolkit:ComboBox ID="cboTipoPac" runat="server">
                    <asp:ListItem Selected="True" Value="Todos"></asp:ListItem>
                    <asp:ListItem Value="Gerente"></asp:ListItem>
                    <asp:ListItem Value="Administrativo"></asp:ListItem>
                    <asp:ListItem Value="Operacional"></asp:ListItem>
                </ajaxToolkit:ComboBox>
            </td>
            <td class="auto-style12"></td>
            <td class="auto-style13"></td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;<asp:Label ID="Label2" runat="server" Text="Cantidad de Evaluaciones -"></asp:Label>
            </td>
            <td class="auto-style9">&nbsp;Mayor o igual a:
                <asp:TextBox ID="txtMayorIgual" runat="server"></asp:TextBox>
                <ajaxToolkit:MaskedEditExtender ID="txtMayorIgual_MaskedEditExtender" runat="server" BehaviorID="txtMayorIgual_MaskedEditExtender" InputDirection="RightToLeft" Mask="99999999" TargetControlID="txtMayorIgual" MaskType="Number" />
            </td>
            <td class="auto-style9">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMayorIgual" CssClass="error" ErrorMessage="Obligatorio"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="btnConsultar" runat="server" CssClass="btn" Text="Consultar" OnClick="btnConsultar_Click" />
            </td>
            <td class="auto-style7"></td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="grvPacEstado" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                        <asp:BoundField DataField="Genero" HeaderText="Genero" />
                        <asp:BoundField DataField="Lugar_de_trabajo" HeaderText="Empresa" />
                        <asp:BoundField DataField="Fecha_Nacimiento" HeaderText="Fecha de Nacimiento" />
                        <asp:BoundField DataField="Dni" HeaderText="DNI" />
                        <asp:BoundField DataField="Dirección" HeaderText="Dirección" />
                        <asp:BoundField DataField="Estado_actual" HeaderText="Estado" />
                        <asp:BoundField DataField="Tipo_Cliente" HeaderText="Tipo de Cliente" />
                        <asp:BoundField DataField="Cantidad_de_evaluaciones" HeaderText="# de Evaluaciones" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </td>
        </tr>
    </table>
    <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
    <asp:Label ID="lblLog" runat="server"></asp:Label>
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">Retornar</asp:HyperLink>
</asp:Content>
