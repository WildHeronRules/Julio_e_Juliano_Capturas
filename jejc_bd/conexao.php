<?php
    $SERVER_NAME = "localhost";
    $DATABASE_NAME = "jejc_bd";
    $USER_NAME = "root";
    $PASSWORD = "";
    
    $chave = "ye";

    $PDO = new PDO("mysql:host=$SERVER_NAME;dbname=$DATABASE_NAME",$USER_NAME, $PASSWORD);
?>