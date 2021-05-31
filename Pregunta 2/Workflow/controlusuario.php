<?php
	include "conexion.inc.php";
    session_start();
    $usuario = $_POST["usuario"];
    $contraseña = $_POST["contrasenia"];
    $res = mysqli_query($conn, "SELECT * FROM usuario WHERE usuario='".$usuario."' AND contrasena='".$contraseña."'");
	$fila = mysqli_fetch_array($res);
	if(isset($fila)){
        $_SESSION['IdUser'] = $fila["Id"];
        $_SESSION['Rol'] = $fila["rol"];
		$res2 = mysqli_query($conn, "SELECT * FROM estudiante WHERE Id='".$_SESSION['IdUser']."'");
		$fila2 = mysqli_fetch_array($res2);
        if(isset($fila2)){
			$_SESSION['Nombre'] = $fila2["nombre"]." ".$fila2["apellidos"];
		}else{
			$_SESSION['Nombre'] = "Usuario Nuevo";
		}
        header("Location: bandeja.php");
    }else{
        echo "Error.";
    }
?>