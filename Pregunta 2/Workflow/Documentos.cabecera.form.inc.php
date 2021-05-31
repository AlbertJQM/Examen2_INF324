<?php
    $sw1 = 0;
    $sw2 = 0;
    $sw3 = 0;

    $sql1 = "SELECT * FROM documentos WHERE DB=1 AND Id=".$_SESSION["IdUser"];
    $resCab1 = mysqli_query($conn, $sql1);
    $filCab1 = mysqli_fetch_array($resCab1);

    $sql2 = "SELECT * FROM documentos WHERE CI=1 AND Id=".$_SESSION["IdUser"];
    $resCab2 = mysqli_query($conn, $sql2);
    $filCab2 = mysqli_fetch_array($resCab2);

    $sql3 = "SELECT * FROM documentos WHERE CN=1 AND Id=".$_SESSION["IdUser"];
    $resCab3 = mysqli_query($conn, $sql3);
    $filCab3 = mysqli_fetch_array($resCab3);
    
    /*echo $sql1."<br>";
    echo isset($filCab1)."<br><br>";
    echo $sql2."<br>";
    echo isset($filCab2)."<br><br>";
    echo $sql3."<br>";
    echo isset($filCab3)."<br><br>";
*/
    if(isset($filCab1)){
        $sw1 = 1;
    }
    if(isset($filCab2)){
        $sw2 = 1;
    }
    if(isset($filCab3)){
        $sw3 = 1;
    }
?>