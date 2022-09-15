<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="ProyCheckWEB_GUI.Consultas.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;
    <p class="tituloForm">CONSULTAS DEL SISTEMA</p>
    <table class="tituloForm">
        <tr>
            <td class="style2">
                <asp:Image ID="Image1" runat="server" Height="267px" 
                    ImageUrl="~/Images/Consultas.jpg" Width="320px" />
            </td>
            <td>
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows" Width="161px">
                    <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                    <Nodes>
                        <asp:TreeNode Text="Consultas del sistema" Value="Consultas del sistema">
                            <asp:TreeNode NavigateUrl="~/Consultas/ConsultaEmpresaEvaluados.aspx" Text="Consulta Empresas Evaluadas" Value="Consulta de facturacion de clientes"></asp:TreeNode>
                            <asp:TreeNode Text="Consulta Estado de Análisis" Value="Consulta de facturacion de vendedores" NavigateUrl="~/Consultas/ConsultaAnalisisEstado.aspx"></asp:TreeNode>
                            <asp:TreeNode Text="Consulta Estado de Pacientes" Value="Consulta paginada de facturas" NavigateUrl="~/Consultas/ConsultaPacienteEstado.aspx"></asp:TreeNode>
                            <asp:TreeNode Text="Consulta Medico" Value="Consulta pacientes atendidos por Medico" NavigateUrl="~/Consultas/ConsultaMedicoPacientes.aspx"></asp:TreeNode>
                            <asp:TreeNode Text="Retornar" Value="Retornar"></asp:TreeNode>
                        </asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
                </asp:TreeView>
            </td>
        </tr>
    </table>
&nbsp;
</asp:Content>


