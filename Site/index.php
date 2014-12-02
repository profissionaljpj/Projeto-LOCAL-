<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<?php
include 'DAOSenha.php';
?>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<link rel="stylesheet" media="screen" type="text/css" title="style"
	href="style.css" />
<title>PocketQueue</title>
</head>

<body>
	<div id="holder">
		<img src="images/LogoPocketqueue2.jpg" alt="logo" width="150" height="140" />
		<div id="letra">PocketQueue</div>
		<div id="shadow">
			<ul id="menu"/>
			</ul>
			<div class="clear"></div>
				<div id="edito" style="display:block; text-align:center">
					<h2>Senha Atual:</h2>
					<div id="editletra" style="display:block; text-align:center">
					<table style="display:inline-block; text-align:center">
						<tr>
							<th style="width:120px;">Senha</th>
							<th style="width:120px;">Guiche</th>
						</tr>
						<tr>
						<?php
							foreach ((DAOSenha::listarPorHora()) as $row){
								echo("<td>".$row['IDSenha']."</td>\n");
								echo("<td>".$row['Guiche']."</td>");
								break;
							}
						?>
						</tr>
					</table>
					<h2>Histórico:</h2>
					<table style="display:inline-block; text-align:center">
						<tr>
							<th style="width:120px;">Senha</th>
							<th style="width:120px;">Guiche</th>
						</tr>
						<?php
							$i = 0;
							foreach ((DAOSenha::listarPorHora()) as $row){
								if ($i!=0){
									echo("<tr><td>".$row['IDSenha']."</td>\n");
									echo("<td>".$row['Guiche']."</td>\n</tr>");
								}
								$i = 1;
							}
						?>
					</table>
					</div>
					
					<div id="emAtendimento" class="emAtendimento chamada" >
						<ul></ul> 
					</div>
					
				 	<div id="jaAtendido" class="jaAtendido chamada">
				 		<ul>
				 		</ul>
					</div>
					<div style="display:block; text-align:center;">
					<button onclick="myFunction()">Atualizar</button>
					</div>
				</div>

			<div class="clear"></div>

		</div>

		<div id="footer">
			<p>
				Contato <a href="#">(xx)-(xxxx-xxxx)</a>
			</p>
		</div>

	</div>
	<script>
function myFunction() {
    window.location.replace("http://localhost");
}
</script>
</body>
</html>
