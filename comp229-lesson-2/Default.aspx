<%@ Page Title="We are learning Asp.Net" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="comp229_lesson_2.Default" %>

<%@ Import Namespace="comp229_lesson_2.Models" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div class="row">

            <div class="col-md-offset-4 col-md-6 col-xs-offset-4 col-xs-6">

                <h1>Hello World</h1>

                <h3><%=TestMe.stringLabel + ": " + TestMe.getRandomValue() %></h3>
            </div>

        </div>
    </div>
</asp:Content>
