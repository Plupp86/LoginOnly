<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LoginExercise._Default" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">


	


	<asp:Panel runat="server" ID="AuthenticatedMessagePanel">
		<div class="main">
			<h1>Welcome!</h1>
		<asp:Label runat="server" ID="WelcomeBackMessage"></asp:Label>
		
			</div>
	</asp:Panel>

	<asp:Panel runat="Server" ID="AnonymousMessagePanel">
		<div class="main">
			<h1>Welcome!</h1>
			<p>In order to access the member page you need to login.</p>
			
		</div>
	</asp:Panel>
</asp:Content>
