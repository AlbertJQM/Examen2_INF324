<?php
    $DB = $_FILES["DocumentoDB"];
    $CI = $_FILES["DocumentoCI"];
    $CN = $_FILES["DocumentoCN"];
    if(!empty($DB)){
        echo "DB No esta vacio";
        //$sql = "UPDATE documentos SET DB=1 WHERE Id=".$_SESSION["IdUser"];
        //$res = mysqli_query($conn, $sql);
    }else{
        echo "DB esta vacio";
    }
    echo $sql;
    if(!empty($CI)){
        $sql = "UPDATE documentos SET CI=1 WHERE Id=".$_SESSION["IdUser"];
        $res = mysqli_query($conn, $sql);
    }else{
        echo "CI esta vacio";
    }
    echo $sql;
    if(!empty($CN)){
        $sql = "UPDATE documentos SET CN=1 WHERE Id=".$_SESSION["IdUser"];
        $res = mysqli_query($conn, $sql);
    }else{
        echo "CN esta vacio";
    }
    echo $sql;
?>