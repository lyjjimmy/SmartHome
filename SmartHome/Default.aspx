<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SmartHome._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Smart Home Medical Monitroing System</h2>
            </hgroup>
            <p>
                To start, select one of the following options below.</p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>We suggest the following:</h3>
    <ol class="round">
        <li class="one">
            <h5><a href="PatientProfile.aspx">Patient Profile and Medical Monitoring</a></h5>
            View your patient profile and&nbsp; monitor your medical status via sensors in site.</li>
        <li class="two">
            <h5><a href="ReminderSetting.aspx">Set a medical reminder</a></h5>
            Setup a medical reminder to help patient remember.</li>
        <li class="three">
            <h5>Find Web Hosting</h5>
            You can easily find a web hosting company that offers the right mix of features and price for your applications.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245143">Learn more…</a>
        </li>
    </ol>
</asp:Content>
