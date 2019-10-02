<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrosSugerencias.aspx.cs" Inherits="RegistroSugerenciaAp2.UI.Registros.RegistrosSugerencias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="panel panel-primary">
            <div class="panel-heading">Registros Sugerencia</div>
            <div class="panel-body">
                <div class="form-horizontal col-md-12" role="form">
                    <%--SugerenciaID--%>
                    <div class="form-group">
                        <label for="IdTextBox" class="col-md-3 control-label input-sm">ID: </label>
                        <div class="col-md-4">
                            <asp:TextBox class="form-control input-sm" TextMode="Number" ID="IdTextBox" Text="0" runat="server"></asp:TextBox>
                        </div>
                        <asp:Button class="col-md-1 btn btn-info btn-sm" ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
                        <label for="fechaTextBox" class="col-md-2 control-label input-sm">Fecha: </label>
                        <div class="col-md-2">
                            <asp:TextBox class="form-control" ID="fechaTextBox" TextMode="Date" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <%--Descripcion--%>
                    <div class="form-group">
                        <label for="DescripcionID" class="col-md-3 control-label input-sm">Descripcion: </label>
                        <div class="col-md-4">
                            <asp:TextBox class="form-control input-sm" ID="DescripcionTextBox" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="DescripcionID" runat="server" MaxLength="200"
                                ControlToValidate="DescripcionTextBox"
                                ErrorMessage="Campo Estudiante obligatorio" ForeColor="Red"
                                Display="Dynamic" SetFocusOnError="True"
                                ToolTip="Campo Descripcion obligatorio" ValidationGroup="Guardar">Por favor llenar el campo Descripcion
                            </asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
            </div>

        </div>
        <div class="panel-footer">
            <div class="text-center">
                <div class="form-group" style="display: inline-block">

                    <asp:Button Text="Nuevo" class="btn btn-warning btn-sm" runat="server" ID="NuevoButton" OnClick="NuevoButton_Click" />
                    <asp:Button Text="Guardar" class="btn btn-success btn-sm" runat="server" ID="GuadarButton" OnClick="GuardarButton_Click" ValidationGroup="Guardar" />
                    <asp:Button Text="Eliminar" class="btn btn-danger btn-sm" runat="server" ID="EliminarButton" OnClick="EliminarButton_Click" />
                    <asp:RequiredFieldValidator ID="EliminarRequiredFieldValidator" CssClass="col-md-1 col-sm-1" runat="server" ControlToValidate="IdTextBox" ErrorMessage="Es necesario elegir ID valido para eliminar" ValidationGroup="Eliminar">Porfavor elige un ID valido.</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="EliminarRegularExpressionValidator" CssClass="col-md-1 col-sm-1 col-md-offset-1 col-sm-offset-1" runat="server" ControlToValidate="PresupuestoTextBox" ErrorMessage="RegularExpressionValidator" ValidationExpression="\d+ " ValidationGroup="Eliminar" Visible="False"></asp:RegularExpressionValidator>

                </div>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
