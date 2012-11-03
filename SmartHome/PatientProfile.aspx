<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientProfile.aspx.cs" Inherits="SmartHome.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 23px;
            width: 216px;
            background-color: #CCCCCC;
        }
        .auto-style5 {
            width: 861px;
        }
        .auto-style9 {
            height: 23px;
            width: 215px;
        }
        .auto-style10 {
            width: 215px;
        }
        .auto-style11 {
            width: 216px;
        }
        .auto-style12 {
            color: #3366FF;
            width: 186px;
            margin-right: 0px;
        }
        .auto-style13 {
            color: #3366FF;
        }
        .auto-style14 {
            width: 215px;
            background-color: #CCCCCC;
        }
        .auto-style15 {
            height: 23px;
            width: 215px;
            background-color: #CCCCCC;
        }
        .auto-style16 {
            width: 215px;
            height: 25px;
        }
        .auto-style17 {
            width: 216px;
            height: 25px;
        }
        .auto-style18 {
            width: 216px;
            background-color: #CCCCCC;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Patient Profile</h2>
            </hgroup>
            <p>
                To start, hit the &quot;Start Live Monitoring&quot; button to start your simulation</p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style5">
        <tr>
            <td class="auto-style9">Patient Name</td>
            <td class="auto-style15">
                <asp:Label ID="patientNameLabel" runat="server" Text="Label for Patient Name" Font-Bold="True" Font-Size="Medium"></asp:Label>
            </td>
            <td class="auto-style9">Patient Contact</td>
            <td class="auto-style2">
                <asp:Label ID="patientContactLabel" runat="server" Text="Label for Patient Contact"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Associated Carrer</td>
            <td class="auto-style14">
                <asp:Label ID="patientCarrerLabel" runat="server" Text="Label for Carrer Info"></asp:Label>
            </td>
            <td class="auto-style10">Associated Doctor</td>
            <td class="auto-style11">
                <asp:Label ID="patientDoctorLabel" runat="server" Text="Label for Doctor Info"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style16"></td>
            <td class="auto-style16"></td>
            <td class="auto-style16"></td>
            <td class="auto-style17"></td>
        </tr>
        <tr>
            <td class="auto-style10">
                <h3 class="auto-style12">Medical Information</h3>
            </td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style10">
                <h4 class="auto-style13">Status Information</h4>
            </td>
            <td class="auto-style11">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">Current Heart Rate</td>
            <td class="auto-style14">
                <asp:Label ID="liveHeartRateLabel" runat="server" Text="Label for Live Heart Rate"></asp:Label>
            </td>
            <td class="auto-style10">Current Fall Status</td>
            <td class="auto-style18">
                <asp:Label ID="liveFallStatusLabel" runat="server" Text="Label for Falling Status"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Current Blood Pressure</td>
            <td class="auto-style14">
                <asp:Label ID="liveBloodPressureLabel" runat="server" Text="Label for Live Blood Pressure"></asp:Label>
            </td>
            <td class="auto-style10">Current Location</td>
            <td class="auto-style18">
                <asp:Label ID="liveLocationLabel" runat="server" Text="Label for Current Location"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Current Body Temperature</td>
            <td class="auto-style14">
                <asp:Label ID="liveTemperatureLabel" runat="server" Text="Label for Live Body Temperature"></asp:Label>
            </td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
        </tr>
    </table>
    <br />
    <asp:Button ID="startRecordButton" runat="server" Text="Start Live Recording" OnClick="startRecordButton_Click" />
    <asp:Button ID="endRecordButton" runat="server" Text="End Live Recording" OnClick="endRecordButton_Click" />
</asp:Content>
