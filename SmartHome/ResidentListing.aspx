<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResidentListing.aspx.cs" Inherits="SmartHome.ResidentListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>.</h1>
                <h2>Your Linked Resident</h2>
            </hgroup>
            <p>
                To view the profile of a resident, click the link.</p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:BulletedList ID="ResidentsBulletedList" runat="server">
    </asp:BulletedList>
</asp:Content>
