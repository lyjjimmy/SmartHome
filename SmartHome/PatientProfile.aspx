<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientProfile.aspx.cs" Inherits="SmartHome.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 861px;
        }
        .auto-style10 {
        }
        .auto-style12 {
            color: #3366FF;
            width: 186px;
            margin-right: 0px;
        }
        .auto-style13 {
            color: #3366FF;
        }
        .auto-style17 {
            height: 23px;
            width: 230px;
            background-color: #CCCCCC;
        }
        .auto-style18 {
            width: 230px;
            background-color: #CCCCCC;
        }
        .auto-style19 {
            width: 230px;
            height: 25px;
        }
        .auto-style23 {
            width: 217px;
        }
        .auto-style25 {
            height: 23px;
            width: 141px;
        }
        .auto-style26 {
            width: 141px;
        }
        .auto-style27 {
            width: 141px;
            height: 25px;
        }
        .auto-style28 {
            height: 23px;
            width: 217px;
            background-color: #CCCCCC;
        }
        .auto-style29 {
            width: 217px;
            background-color: #CCCCCC;
        }
        .auto-style30 {
            width: 217px;
            height: 25px;
        }
        .auto-style31 {
            height: 23px;
            width: 163px;
        }
        .auto-style32 {
            width: 163px;
        }
        .auto-style33 {
            width: 163px;
            height: 25px;
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
            <td class="auto-style31">Patient Name</td>
            <td class="auto-style28">
                <asp:Label ID="patientNameLabel" runat="server" Text="Label for Patient Name" Font-Bold="True" Font-Size="Medium"></asp:Label>
            </td>
            <td class="auto-style25">Patient Contact</td>
            <td class="auto-style17">
                <asp:Label ID="patientContactLabel" runat="server" Text="Label for Patient Contact"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style32">Associated Carrer</td>
            <td class="auto-style29">
                <asp:BulletedList ID="carrersBulletedList" runat="server">
                </asp:BulletedList>
            </td>
            <td class="auto-style26">Associated Doctor</td>
            <td class="auto-style18">
                <asp:BulletedList ID="doctorsBulletedList" runat="server">
                </asp:BulletedList>
            </td>
        </tr>
        <tr>
            <td class="auto-style33"></td>
            <td class="auto-style30"></td>
            <td class="auto-style27"></td>
            <td class="auto-style19"></td>
        </tr>
        <tr>
            <td class="auto-style32">
                <h3 class="auto-style12">Medical Information</h3>
            </td>
            <td class="auto-style23">&nbsp;</td>
            <td class="auto-style10" colspan="2">
                <h4 class="auto-style13">Status Information</h4>
            </td>
        </tr>
        <tr>
            <td class="auto-style32">Current Heart Rate</td>
            <td class="auto-style29">
                <asp:Label ID="liveHeartRateLabel" runat="server"></asp:Label>
            </td>
            <td class="auto-style26">Current Fall Status</td>
            <td class="auto-style18">
                <asp:Label ID="liveFallStatusLabel" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style32">Current Blood Pressure</td>
            <td class="auto-style29">
                <asp:Label ID="liveBloodPressureLabel" runat="server"></asp:Label>
            </td>
            <td class="auto-style26">Current Location</td>
            <td class="auto-style18">
                <asp:Label ID="liveLocationLabel" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style32">Current Body Temperature</td>
            <td class="auto-style29">
                <asp:Label ID="liveTemperatureLabel" runat="server"></asp:Label>
            </td>
            <td class="auto-style26">Medical Alarm</td>
            <td class="auto-style18">
                <asp:Label ID="alarmStatusLabel" runat="server" ForeColor="#006600" Text="Normal"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="startRecordButton" runat="server" Text="Start Live Recording" OnClick="startRecordButton_Click" />
    <asp:Button ID="endRecordButton" runat="server" Text="End Live Recording" OnClick="endRecordButton_Click" />
    <asp:Timer ID="monitorTimer" runat="server" Enabled="False" Interval="5000" OnTick="monitorTimer_Tick">
    </asp:Timer>
</asp:Content>
