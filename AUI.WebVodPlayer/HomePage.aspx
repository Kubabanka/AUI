<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="AUI.WebVodPlayer.HomePage" %>
<%@ Import Namespace="System.Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:ListView ID="MoviesList" runat="server" OnSelectedIndexChanged="MoviesList_SelectedIndexChanged" OnSelectedIndexChanging="MoviesList_SelectedIndexChanging">
        <LayoutTemplate>
            <h3 style="width: 100%; text-align: left; margin: 10px;">Movies to chose:</h3>
            <ul class="list-group" style="width: 100%; text-align: left; margin: 10px;">
                <li runat="server"  class="list-group-item" id="itemPlaceholder" />
            </ul>
        </LayoutTemplate>
        <ItemTemplate>
            <li runat="server" style="border: 0px" class="list-group-item">
                <asp:LinkButton ID="LinkButton1" CssClass="btn btn-primary" CommandName="Select" runat="server"><%#Eval("Name") %></asp:LinkButton>
            </li>
        </ItemTemplate>
        <SelectedItemTemplate>
            <asp:LinkButton runat="server" Text="<%# Container.DataItem %>" CssClass="list-group-item" />
        </SelectedItemTemplate>
    </asp:ListView>
</asp:Content>
