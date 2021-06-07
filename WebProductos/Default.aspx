<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebProductos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-12">
            <hr class="py-3" />

            <%--<h5 class="justify-content-center display-5 ">Categorias </h5>--%>
            <ul class="nav justify-content-center">
                <% foreach (dominio.Categoria item in categoria)
                {%>

                    <li class="nav-item">
                    <a class="nav-link btn btn-outline-success" href="#"><% = item.Descripcion %></a>
                    </li>

                  <%} %>
               
            </ul>
        </div>

    <div class="row">
        <div id="demo" class="carousel slide " data-ride="carousel">

            <!-- Indicators -->
            <ul class="carousel-indicators">
                <li data-target="#demo" data-slide-to="0" class="active"></li>
                <li data-target="#demo" data-slide-to="1"></li>
                <li data-target="#demo" data-slide-to="2"></li>
            </ul>

            <!-- The slideshow -->
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="img/fond1.PNG" alt="Los Angeles" width="1100" height="500">
                </div>
                <div class="carousel-item">
                    <img src="img/fond2.PNG" alt="Chicago" width="1100" height="500">
                </div>
                <div class="carousel-item">
                    <img src="img/fond3.PNG" alt="New York" width="1100" height="500">
                </div>
            </div>

            <!-- Left and right controls -->
            <a class="carousel-control-prev" href="#demo" data-slide="prev">
                <span class="carousel-control-prev-icon"></span>
            </a>
            <a class="carousel-control-next" href="#demo" data-slide="next">
                <span class="carousel-control-next-icon"></span>
            </a>
        </div>
        </div>
        
    <div class="row">
       <div class="col-3 container">
            <p>
                <img class="rounded" src="img/barraImg.PNG" " />
            </p>
         </div>
         <div class="col-3">
            <p>
                <img class="rounded" src="img/barraImg2.PNG" " />
            </p>
         </div>
         <div class="col-3">
            <p>
                <img class="rounded" src="img/barraImg3.PNG" " />
            </p>
         </div>
         <div class="col-3">
            <p>
                <img class="rounded" src="img/barraImg4.PNG" " />
            </p>
         </div>
    </div>
        <%--<div class="col-md-6">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-6">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>--%>
 
</asp:Content>
