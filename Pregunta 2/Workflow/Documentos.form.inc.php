    <center>
        <div class="alert alert-success" role="alert" style="width: 40rem;">
            <h4 class="alert-heading">Bienvenido <?php echo $_SESSION['Nombre'];?></h4>
            <p>Adjunta tus últimos documentos para poder continuar con tu inscripción.</p>
            <p class="mb-0">Fecha de Ingreso: <?php echo date("Y-m-d");?></p>
            <hr>
            <div class="card">
                <div class="card-header">
                    DOCUMENTOS PERSONALES
                </div>
                <div class="card-body">
                    <div class="mb-3">
                        <label for="FileDocumentoDB" class="form-label">Documento de Bachiller</label>
                        <?php 
                            if($sw1 == 0){
                                echo "<input class='form-control btn btn-primary' type='file' id='formDocumentoDB' name='DocumentoDB'>";
                            }else{
                                echo "<br>YA SUBIÓ SU DOCUMENTO DE BACHILLER.";
                            }
                        ?>                        
                    </div>
                    <div class="mb-3">
                        <label for="FileDocumentoCI" class="form-label">Cédula de Identidad</label>
                        <?php 
                            if($sw2 == 0){
                                echo "<input class='form-control btn btn-primary' type='file' id='formDocumentoCI' name='DocumentoCI'>";
                            }else{
                                echo "<br>YA SUBIÓ SU CÉDULA DE IDENTIDAD.";
                            }
                        ?>                        
                    </div>
                    <div class="mb-3">
                        <label for="FileDocumentoCN" class="form-label">Certificado de Nacimiento</label>
                        <?php 
                            if($sw3 == 0){
                                echo "<input class='form-control btn btn-primary' type='file' id='formDocumentoCN' name='DocumentoCN'>";
                            }else{
                                echo "<br>YA SUBIÓ SU CERTIFICADO DE NACIMIENTO.";
                            }
                        ?>                        
                    </div>
                </div>
            </div>
        </div>
    </center>