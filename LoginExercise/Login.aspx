<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginExercise.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="main">

		<div class="form-group row">
			<label for="userName" class="col-sm-2 col-form-label">User Name:</label>
			<div class="col-sm-10">
				<input type="text" class="form-control" id="userName" placeholder="User Name" runat="server">
				<span runat="server" id="userNameError">User Name does not exist!</span>
			</div>
		</div>
		<div class="form-group row">
			<label for="password" class="col-sm-2 col-form-label">Password:</label>
			<div class="col-sm-10">
				<input type="password" class="form-control" id="password" placeholder="Password" runat="server">
				<span runat="server" id="passwordError">Wrong password</span>
			</div>
		</div>

		<div class="form-group row">
			<div class="offset-sm-2 col-sm-10">
				<asp:Button runat="server" ID="btnLogin" Text="Sign In" OnClick="submit_Click" class="btn btn-primary" />
			</div>
		</div>
	</div>
</asp:Content>
