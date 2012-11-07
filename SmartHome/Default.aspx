<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SmartHome._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>.</h1>
                <h2>Smart Home Medical Monitroing System</h2>
            </hgroup>
            <p>
                Please Log in before accessing system features.</p>
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
            <h5>Set a medical reminder</h5>
            Setup a medical reminder to help patient remember.</li>
    </ol>
</asp:Content>
