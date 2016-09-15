<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="comp229_lesson_2.Default" %>

<%@ Import Namespace="comp229_lesson_2.Models" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Learning Asp.Net</title>

    <!-- Css Section -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
    <link href="Content/app.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            
            <div class="row">

                <div class="col-md-offset-4 col-md-6 col-xs-offset-4 col-xs-6">

                    <h1>Hello World</h1>

                    <h3><%=TestMe.stringLabel + ": " + TestMe.getRandomValue() %></h3>
                </div>

            </div>

        </div>
    </form>

    <script src="Scripts/jquery-2.2.4.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/app.js"></script>
</body>
</html>
