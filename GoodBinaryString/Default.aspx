<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GoodBinaryString._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Good Binary String Test</h1>
        <p class="lead">Enter your string below</p>
        <p>          
            <asp:TextBox runat="server" ID="txtBinaryString" ></asp:TextBox>
            <asp:Button runat="server" ID="btnSubmit"  class="btn btn-primary btn-lg" Text="Submit" OnClick="btnSubmit_Click"  />
        </p>
         <div style="font-size:18px;">e.g (Good String : 110010) (Bad String : 11010) </div><br />
                
        <h3>Result</h3>      
        <asp:Label runat="server" ID="Label1"></asp:Label><br />
        <asp:Label runat="server" ID="Label2"></asp:Label><br />
        <asp:Label runat="server" ID="Label3"></asp:Label><br />
        <asp:Label runat="server" ID="Label4"></asp:Label><br />
        <asp:Label runat="server" ID="Label5"></asp:Label><br />
        <asp:Label runat="server" ID="Label6"></asp:Label><br />
         <asp:Label runat="server" ID="Label7"></asp:Label><br /><br />
         <asp:Label runat="server" ID="Label8" Font-Bold="true" ></asp:Label>
       
    </div>


</asp:Content>
