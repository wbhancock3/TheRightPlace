<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Testimonials.aspx.cs" Inherits="TheRightPlace.Pages.Testimonials" %>

<asp:Content ID="requestHead" ContentPlaceHolderID="headPlaceHolder" runat="server">
    <title>Testimonials</title>
    <style type="text/css">
        .auto-style3 {
            width: 200px;
            height: 133px;
        }
        .auto-style4 {
            width: 200px;
            height: 134px;
        }
    </style>
</asp:Content>
<asp:Content ID="TestimonialsContent" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="form-group">
        <div class="col-md-2 col-md-offset-1">
           <img src="../Images/Testimonials/pambranagan.jpg" class="auto-style3" />
        </div>
        <div class="col-md-7 col-md-offset-1">
            <p>"Another successful conference! Thanks, in a huge part, to you! We,
                         The NEARC Board, are in awe of you and your expertise, not to mention how
                         you manage it all with a smile! Your help from the very beginning (practically a year ago)
                         – keeping us on track, meeting deadlines, guiding the host committee – to all of the onsite
                         work you do – registration, food, dealing with issues (wifi…ugh!) – is appreciated by all of us."<br />
                <b>- Pam Branagan, Chair NEARC Board of Directors</b>
            </p>
        </div>
    </div>
    <br />
    <div class="form-group">
        <div class="col-md-7 col-md-offset-1">
            <p>"Thank you very sincerely for your expert services in the production of the Roundtable's Summer Celebration.
                 To say that "we couldn't have done it without you" is a gross understatement... and you can quote me on that!"<br />
                <b>- Lisa Ventriss, President Oklahoma Business Roundtable</b>
            </p>
        </div>
        <div class="col-md-3">
           <img src="../Images/Testimonials/lisaventriss.jpg" class="auto-style3" />
        </div>
    </div>
    <br />
    <div class="form-group">
        <div class="col-md-2 col-md-offset-1">
            <img src="../Images/Testimonials/joanmiller.png" class="auto-style4" />
        </div>
        <div class="col-md-7 col-md-offset-1">
            <p>"Our ninth annual two-day product expo is once again a successful show and you and your staff were able to make
                 that happen for us. Your services were very impressive! Many of our volunteers expressed how you were like an
                 anchor and you were always willing to help out at anything we needed. Your attitude was very uplifting and it
                 really made a difference when things were hectic."<br />
                <b>- Joan Miller, MHEC/Customer Service Manager Oklahoma Higher Education Consortium</b>
            </p>
        </div>
    </div>

</asp:Content>
