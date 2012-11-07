<%@ Page Title="Access Denied" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AccessDenied.aspx.cs" Inherits="SmartHome.AccessDenied" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Smart Home Monitoring System</h2>
    </hgroup>

    <article>
        <p>        
            You have reached this page because you are not logged into the system or do not possess the priveliges to access this page, if you believe that this mistake was in error, please contact the system administrator.
        </p>

        <p>        
            You will be redirected to the main page in a few seconds.
        </p>
        
        <p>        
            
        </p>
    </article>
</asp:Content>