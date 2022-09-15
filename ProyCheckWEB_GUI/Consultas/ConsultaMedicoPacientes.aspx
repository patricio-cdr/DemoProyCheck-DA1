<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="ConsultaMedicoPacientes.aspx.cs" Inherits="ProyCheckWEB_GUI.Consultas.ConsultaMedicoPacientes" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            box-sizing: border-box;
            padding: 20px 0px;
        }
        .auto-style12 {
            height: 70px;
            display: flex;
            justify-content: center;
            align-items: center;
        }
        .auto-style14 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Consulta medico</h1>
    <table width="1000px">
        <tr>
            <td>Ingrese Medico</td>
            <td width="150px">
                <asp:TextBox ID="txtCodigo" runat="server" CssClass="TextBox" MaxLength="4" Width="70px"></asp:TextBox>
                &nbsp;
                <asp:ImageButton ID="btnBuscar" runat="server" ImageUrl="~/Images/Buscar.png" OnClick="btnBuscar_Click" style="width: 16px" CausesValidation="False"  />
                <asp:Label ID="Label1" runat="server" Text="Ingrese 0011"></asp:Label>
            </td>
            <td>Especialidad</td>
            <td>
                <asp:TextBox ID="txtEspecialidad" runat="server" CssClass="TextBox" Height="22px" Width="154px" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Nombre:</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="TextBox" Height="22px" style="margin-left: 0" Width="288px" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
            <td>Ubigeo: </td>
            <td>
                <asp:TextBox ID="txtUbigeo" runat="server" CssClass="TextBox" Height="22px" Width="231px" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Apellido:</td>
            <td>
                <asp:TextBox ID="txtApellido" runat="server" CssClass="TextBox" Height="22px" Width="287px" Enabled="False"></asp:TextBox>
            </td>
            <td>Dirección:</td>
            <td>
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="TextBox" Height="22px" Width="157px" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">DNI:</td>
            <td class="auto-style14">
                <asp:TextBox ID="txtDni" runat="server" CssClass="TextBox" Height="22px" Width="145px" Enabled="False"></asp:TextBox>
            </td>
            <td class="auto-style14">Estado:</td>
            <td class="auto-style14">
                <asp:TextBox ID="txtEstado" runat="server" CssClass="TextBox" Height="22px" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7" colspan="4"><h4>INGRESE FECHAS DE PACIENTES ATENDIDOS ( * Obligatorios):</h4></td>
        </tr>
        <tr>
            <td>Fecha Inicio (*):</td>
            <td>
                <asp:TextBox ID="txtFechInicio" runat="server"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="txtFechInicio_CalendarExtender" runat="server" TargetControlID="txtFechInicio" />
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFechInicio" CssClass="labelErrores" ErrorMessage="*"></asp:RequiredFieldValidator>
               
            </td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" CssClass="btn" Text="Consultar" OnClick="btnConsultar_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="Ingrese 1/1/2019"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">Retornar</asp:HyperLink>
            </td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="grvPacienteAtendido" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Paciente" HeaderText="Paciente" />
                        <asp:BoundField DataField="Dni" HeaderText="Dni" />
                        <asp:BoundField DataField="Fech_Nacimiento" DataFormatString="{0:d}" HeaderText="Fec. Nacimiento"  />
                        <asp:BoundField DataField="Correo" HeaderText="Correo" />
                        <asp:BoundField DataField="Genero" HeaderText="Género" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo"/>
                        <asp:BoundField DataField="Dirección" HeaderText="Direccion" />
                        <asp:BoundField DataField="Analisis" HeaderText="Analisis" />
                        <asp:BoundField DataField="Enfermedad" HeaderText="Enfermedad" />
                        <asp:BoundField DataField="Fech_Atendida" DataFormatString="{0:d}" HeaderText="Fec. Evaluacion" />
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
    <br />
    <asp:Label ID="lblRegistro" runat="server"></asp:Label>


    <asp:LinkButton ID="lnkMensaje" runat="server"></asp:LinkButton>


    <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500"> 
                    <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color:black ; 
                        color: #FFFFFF;"> 
                        <tr> 
                            <td align="center"> 
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" /> 
                            </td> 
                             
                        </tr>  
                    </table> 
                    <div class="auto-style12"> 
                        <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor ="Black"/> 
                        
                    </div> 
                    <div class="auto-style5"> 
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CausesValidation="False" CssClass="boton-new"/> 
                    </div> 
                </asp:Panel> 
    <ajaxToolkit:ModalPopupExtender ID="mpMensaje" runat="server" TargetControlID="lnkMensaje"
        PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion"  OkControlID="btnAceptar">
                        </ajaxToolkit:ModalPopupExtender>
</asp:Content>
