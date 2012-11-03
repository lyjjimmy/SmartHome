<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReminderSetting.aspx.cs" Inherits="SmartHome.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 145px;
            text-align: right;
            font-size: medium;
        }
        .auto-style2 {
            width: 145px;
            height: 23px;
            text-align: right;
            font-size: medium;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            background-color: #CCCCCC;
            height: 57px;
        }
        .auto-style5 {
            width: 145px;
            text-align: right;
            background-color: #CCCCCC;
            height: 57px;
            font-size: medium;
        }
        .auto-style6 {
            font-size: medium;
        }
        .auto-style7 {
            width: 218px;
        }
        .auto-style8 {
            width: 191px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Medical Reminder</h2>
            </hgroup>
            <p>
                Here you can set a reminder for a patient. To start, fill the form and submit the request to the server.</p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style2">Receving Patient</td>
            <td class="auto-style3">
                <asp:DropDownList ID="patientDropList" runat="server" Height="35px" Width="456px" Font-Size="Medium">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Notification Time</td>
            <td class="auto-style4">
                <span class="auto-style6">Notification time set as: <strong>
                <asp:Label ID="dateTextLabel" runat="server" Text="Date"></asp:Label>
&nbsp;<asp:Label ID="timeTextLabel" runat="server" Text="Time"></asp:Label>
                </strong></span>
                <br />
                <table style="width: 69%;">
                    <tr>
                        <td class="auto-style7">
                            <asp:Calendar ID="datePicker" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" FirstDayOfWeek="Sunday" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="84px" OnSelectionChanged="datePicker_SelectionChanged" Width="21px">
                                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                                <OtherMonthDayStyle ForeColor="#999999" />
                                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                                <WeekendDayStyle BackColor="#CCCCFF" />
                            </asp:Calendar>
                        </td>
                        <td class="auto-style8">Hour<br />
                            <asp:DropDownList ID="hourPicker" runat="server" Height="20px" OnSelectedIndexChanged="hourPicker_SelectedIndexChanged" Width="118px">
                                <asp:ListItem Value="0">00</asp:ListItem>
                                <asp:ListItem Value="1">01</asp:ListItem>
                                <asp:ListItem Value="2">02</asp:ListItem>
                                <asp:ListItem Value="3">03</asp:ListItem>
                                <asp:ListItem Value="4">04</asp:ListItem>
                                <asp:ListItem Value="5">05</asp:ListItem>
                                <asp:ListItem Value="6">06</asp:ListItem>
                                <asp:ListItem Value="7">07</asp:ListItem>
                                <asp:ListItem Value="8">08</asp:ListItem>
                                <asp:ListItem Value="9">09</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>11</asp:ListItem>
                                <asp:ListItem>12</asp:ListItem>
                                <asp:ListItem>13</asp:ListItem>
                                <asp:ListItem>14</asp:ListItem>
                                <asp:ListItem>15</asp:ListItem>
                                <asp:ListItem>16</asp:ListItem>
                                <asp:ListItem>17</asp:ListItem>
                                <asp:ListItem>18</asp:ListItem>
                                <asp:ListItem>19</asp:ListItem>
                                <asp:ListItem>20</asp:ListItem>
                                <asp:ListItem>21</asp:ListItem>
                                <asp:ListItem>22</asp:ListItem>
                                <asp:ListItem>23</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                            Minute<br />
                            <asp:DropDownList ID="minutePicker" runat="server" Height="20px" OnSelectedIndexChanged="minutePicker_SelectedIndexChanged" Width="119px">
                                <asp:ListItem Value="0">00</asp:ListItem>
                                <asp:ListItem Value="5">05</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>15</asp:ListItem>
                                <asp:ListItem>20</asp:ListItem>
                                <asp:ListItem>25</asp:ListItem>
                                <asp:ListItem>30</asp:ListItem>
                                <asp:ListItem>35</asp:ListItem>
                                <asp:ListItem>40</asp:ListItem>
                                <asp:ListItem>45</asp:ListItem>
                                <asp:ListItem>50</asp:ListItem>
                                <asp:ListItem>55</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                            <asp:Button ID="updateButton" runat="server" OnClick="updateButton_Click" Text="Update Time" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Reminder</td>
            <td>
                <asp:TextBox ID="reminderMessageBox" runat="server" Height="137px" Width="444px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" />
                <asp:Button ID="clearButton" runat="server" OnClick="clearButton_Click" Text="Clear" />
            </td>
        </tr>
    </table>
</asp:Content>
