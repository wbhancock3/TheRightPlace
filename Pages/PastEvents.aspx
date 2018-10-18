<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PastEvents.aspx.cs" Inherits="TheRightPlace.Pages.PastEvents" %>

<asp:Content ID="requestHead" ContentPlaceHolderID="headPlaceHolder" runat="server">
    <title>Past Events</title>
</asp:Content>
<asp:Content ID="PastEventsContent" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row">
        <div id="my-slider" class="carousel slide" data-ride="carousel" data-interval="false">
            <!-- dot intervals nav -->
            <ol class="carousel-indicators">
                <li data-target="#myslider" data-slide-to="0" class="active"></li>
                <li data-target="#myslider" data-slide-to="1"></li>
                <li data-target="#myslider" data-slide-to="2"></li>
                <li data-target="#myslider" data-slide-to="3"></li>
                <li data-target="#myslider" data-slide-to="4"></li>
            </ol>
            <!--wrapper for slides -->
            <div class="carousel-inner" role="listbox">
                <div class="item active">
                    <img src="../Images/PastEvents/PEauditorium1.jpg" alt="PEauditorium1"/>
                    <div class="carousel-caption">
                        <h2>WIN Summit 2017</h2>
                    </div>
                </div>
                <div class="item">
                    <img src="../Images/PastEvents/PEindoorwedding1.jpg" alt="indoorwedding1"/>
                    <div class="carousel-caption">
                        <h2>Schillenger - Watson Wedding 2015</h2>
                    </div>
                </div>
                <div class="item">
                    <img src="../Images/PastEvents/PEballroom2.jpg" alt="ballroom2" />
                    <div class="carousel-caption">
                        <h2>OSU Alumni Association Annual Ball</h2>
                    </div>
                </div>
                <div class="item">
                    <img src="../Images/PastEvents/PEcourtyard2.jpg" alt="courtyard2"/>
                    <div class="carousel-caption">
                        <h2>Bates - Hess Wedding 2014</h2>
                    </div>
                </div>
                <div class="item">
                    <img src="../Images/PastEvents/PEcourtyard1.jpg" alt="courtyard1"/>
                    <div class="carousel-caption">
                        <h2>Dupree - Fairchild Wedding 2016</h2>
                    </div>
                </div>


                <!-- next and prev buttons -->
                <a class="left carousel-control" href="#my-slider" role="button" data-slide="prev" >
                    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                </a>
                <a class="right carousel-control" href="#my-slider" role="button" data-slide="next">
                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                </a>
            </div>
        </div>
    </div>



</asp:Content>
