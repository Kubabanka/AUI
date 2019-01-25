<%@ Page Title="Video" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VideoPage.aspx.cs" Inherits="AUI.WebVodPlayer.VideoPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <script src="Scripts/dash.all.js"></script>
    <script>
        // setup the video element and attach it to the Dash player
        setTimeout(function setupVideo() {
                var url = '<%=movieUrl%>';
                var context = new Dash.di.DashContext();
                var player = new MediaPlayer(context);
                player.startup();
                player.attachView(document.querySelector("#videoplayer"));
                player.attachSource(url);
            },
            10000);
    </script>
    <div onload="setupVideo()">
    <h1></h1>
    <video id="videoplayer" controls></video>
    </div>
    <style>
        video {
            width: 80%;
            height: 80%;
        }
    </style>
</asp:Content>
