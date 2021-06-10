<?php
	include "conexao.php";

	$query = $PDO->prepare("SELECT * FROM pontuacao
							ORDER BY pontos DESC LIMIT :limite");

	$query->bindValue(':limite', $_POST['limite'], PDO::PARAM_INT);
	$query->execute();

	$resultado = $query->fetchAll(PDO::FETCH_ASSOC);

	$json = json_encode(array("objetos" => $resultado));

	print_r($json);
?>