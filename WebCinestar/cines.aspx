﻿<%@ Page Title="" Language="C#" MasterPageFile="~/CineStar.Master" AutoEventWireup="true" CodeBehind="cines.aspx.cs" Inherits="WebCinestar.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contenido-interno" id="contenido-interno">

				<br/
                    ><h1>Nuestros Cines</h1>
                <br/>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                            
	        <div class="contenido-cine">
	         <img src="img/cine/1.1.jpg" width="227" height="170"/>
   	         	<div class="datos-cine">
    				   	<h4>Excelsior</h4><br/>
              
          		<span>Jirón de la Unión 780 - Lima<br/><br/>Teléfono: 714-1865 anexo 865</span>
        	</div>
        	<br/>
            	<a href="cine.aspx?idCine=">
          		<img src="img/varios/ico-info2.png" width="150" height="40"/>
            	</a>
	        </div>

            </div>
                        
                    </ItemTemplate>
                    </asp:Repeater>
                
</asp:Content>
