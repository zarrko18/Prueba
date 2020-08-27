<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    


  <div class="container pt-4 pb-4">
    <div class="row ml-1 mr-1 panel-theme">
      <div class="col-lg-12">

        <asp:UpdatePanel ID="UpdatePanel24" runat="server">
          <ContentTemplate>
            <div class=" row pt-4 pb-4" runat="server" id="mensajePermiso" visible="false">
              <div class="alert alert-danger col-lg-10 col-md-10 col-sm-10 col-xs-10 text-center offset-1 " role="alert">
                <i class="fa fa-info-circle"></i>&nbsp;
                  <asp:Label ID="lblMensajePermisos" runat="server"></asp:Label>
              </div>
            </div>
          </ContentTemplate>
        </asp:UpdatePanel>

        <div class="row col-lg-12 col-md-12 col-sm-12 ">
          <div class="col-lg-3 col-md-3 col-sm-3 pt-2">
            <h5 class="ml-3" style="color: black; text-transform: uppercase;">Permisos</h5>
          </div>
        </div>
        <asp:UpdatePanel ID="upNum4" runat="server">
          <ContentTemplate>
            <div class="row">
              <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6  pt-4 pb-3">
                <div class="form-group" style="margin-right: 2rem;">
                  <asp:Label ID="lblPerfil" CssClass="col-lg-3 col-md-6 col-sm-6 col-xs-6 lead text-right" runat="server" Text="Perfiles:"></asp:Label>
                  <div class="col-lg-7 col-md-6 col-sm-6 col-xs-6 pl-lg-0">
                    <div class="input-group">

                      <asp:DropDownList ID="ddlPerfiles" 
                        CssClass="chosen-select form-control mb-0" runat="server" AutoPostBack="true">
                      </asp:DropDownList>
                    </div>
                  </div>
                </div>
              </div>

            </div>

          </ContentTemplate>
        </asp:UpdatePanel>

</asp:Content>
