<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="ConsultaAnalisisEstado.aspx.cs" Inherits="ProyCheckWEB_GUI.consultas.ConsultaAnalisisEstado" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        html {
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        }

        h1{
            text-align: center;
        }

        #data{
            display: flex;
            gap: 10px;
            align-items: center;
        }

        .error{
            color: #ff0000;
        }

        .btn{
            border: none;
            background: #0094ff;
            color: white;
            padding: 10px 40px;
            border-radius: 8px;
            margin: 10px 0;
        }

        table {
             text-align: center;
        }

        td {
            padding: 10px 0;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Consultas Analisis Check Salud</h1>
    <div id="data">
        <asp:Label ID="Label1" runat="server" Text="Estado de análisis:"></asp:Label>
        <ajaxToolkit:ComboBox ID="cboPacientes" runat="server">
            <asp:ListItem Selected="True">Todos</asp:ListItem>
            <asp:ListItem>Pendiente</asp:ListItem>
            <asp:ListItem>Finalizado</asp:ListItem>
        </ajaxToolkit:ComboBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Seleccion Paciente" CssClass="error" ControlToValidate="cboPacientes"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="btn" OnClick="btnConsultar_Click" />
        <asp:Label ID="lblMensaje" runat="server" CssClass="error"></asp:Label>
    </div>
    <asp:GridView ID="grvAnalisis" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1213px" AllowPaging="True" OnPageIndexChanging="grvAnalisis_PageIndexChanging">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="codAnalisis" HeaderText="Codigo" />
            <asp:BoundField DataField="NombrePaciente" HeaderText="Nombre" />
            <asp:BoundField DataField="ApellidoPaciente" HeaderText="Apellidos" />
            <asp:BoundField DataField="Lugar_de_trabajo" HeaderText="Lugar de trabajo" />
            <asp:BoundField DataField="TipoAnalisis" HeaderText="Tipo Analisís" />
            <asp:BoundField DataField="CostoAnalisis" HeaderText="Costo Analisís S/." DataFormatString="{0:n}" />
            <asp:BoundField DataField="FechaEvaluacion" HeaderText="Fec. Evaluación" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" />
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
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">Retornar</asp:HyperLink>
</asp:Content>
