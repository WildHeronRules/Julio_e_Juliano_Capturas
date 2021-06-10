<?php
    include "conexao.php";
    //Consultar no BD
    $queryConsulta = $PDO->prepare("SELECT pontos FROM pontuacao WHERE jogador = :jogador");

    //Envia parтmetros para a consulta
    $queryConsulta->execute([
        ":jogador" => $_POST['jogador']
    ]);

    //Transforma o resultado em uma array
    $resultado = $queryConsulta->fetchAll(PDO::FETCH_ASSOC);

    //Preparar uma nova pontuaчуo
    $query = $PDO->prepare("INSERT INTO pontuacao (  jogador,  pontos ) 
                            VALUES ( :jogador, :pontos ) ");

    //Executa o Update ou Insert ... 
    $query->execute([
        ":jogador" => $_POST['jogador'],
        ":pontos"  => $_POST['pontos']
    ]);

    echo "Ok";
?>