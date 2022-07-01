﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="UserPanel.Panel.ErrorPage" %>

<!DOCTYPE html>

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<meta name="viewport" content="width=device-width"/>
<title>Bingo Admin - All Purpose Responsive Admin Template</title>
<link href="css/reset.css" rel="stylesheet" type="text/css">
<link href="css/layout.css" rel="stylesheet" type="text/css">
<link href="css/themes.css" rel="stylesheet" type="text/css">
<link href="css/typography.css" rel="stylesheet" type="text/css">
<link href="css/styles.css" rel="stylesheet" type="text/css">
<link href="css/shCore.css" rel="stylesheet" type="text/css">
<link href="css/bootstrap.css" rel="stylesheet" type="text/css">
<link href="css/jquery.jqplot.css" rel="stylesheet" type="text/css">
<link href="css/jquery-ui-1.8.18.custom.css" rel="stylesheet" type="text/css">
<link href="css/data-table.css" rel="stylesheet" type="text/css">
<link href="css/form.css" rel="stylesheet" type="text/css">
<link href="css/ui-elements.css" rel="stylesheet" type="text/css">
<link href="css/wizard.css" rel="stylesheet" type="text/css">
<link href="css/sprite.css" rel="stylesheet" type="text/css">
<link href="css/gradient.css" rel="stylesheet" type="text/css">
<link href='http://fonts.googleapis.com/css?family=Oswald' rel='stylesheet' type='text/css'>
<!--[if IE 7]>
<link rel="stylesheet" type="text/css" href="css/ie/ie7.css" />
<![endif]-->
<!--[if IE 8]>
<link rel="stylesheet" type="text/css" href="css/ie/ie8.css" />
<![endif]-->
<!--[if IE 9]>
<link rel="stylesheet" type="text/css" href="css/ie/ie9.css" />
<![endif]-->
<!-- Jquery -->
<script src="js/jquery-1.7.1.min.js"></script>
<script src="js/jquery-ui-1.8.18.custom.min.js"></script>
<script src="js/jquery.tipsy.js"></script>
<script type="text/javascript">
$(function(){
	$(window).resize(function(){
		$('.error_container').css({
			position:'absolute',
			left: ($(window).width() - $('.error_container').outerWidth())/2,
			top: ($(window).height() - $('.error_container').outerHeight())/2
		});
	});
	// To initially run the function:
	$(window).resize();
	$('.home_link a').tipsy({
			title: 'title',
			fade: 'out',     // fade tooltips in/out?
			gravity: 's',
			});// nw | n | ne | w | e | sw | s | se
});
</script>
</head>
<body id="theme-default" class="full_block">
<div id="error_404">
	<div class="error_container">
		<div class="error_info">
			<div class="error_code">
				405
			</div>
			<div class="error_meta">
				<span>Oops!</span>Error...
			</div>
			<span class="clear"></span>
		</div>
		<div class="error_content">
			<div class="error_message">
				<span>We are sorry</span> The page you are trying to reach dose not exist :(
			</div>
			<div class="home_link">
				<a href="dashboard.html" title="GO TO HOME">Home</a>
			</div>
			<span class="clear"></span>
		</div>
		<div class="error_instruction">
			<div class="instruction_list">
				<h3>Lost? We suggest...</h3>
				<ol>
					<li>Checking the web address for typos.</li>
					<li>Visiting the home page (link to the Right).</li>
					<li>Visiting our full website <a href="#">sitemap here.</a></li>
					<li>Using our site search below.</li>
				</ol>
			</div>
			<div class="mark_icon">
				?
			</div>
			<span class="clear"></span>
		</div>
		<div class="error_search">
			<form action="#" method="get">
				<ul>
					<li><input name="" type="text" class="error_searchbox" value="Topic Search..."></li>
					<li><button type="submit" class="btn_small btn_blue error_searchbtn"><span>Search</span></button></li>
				</ul>
			</form>
		</div>
	</div>
</div>
</body>
</html>
