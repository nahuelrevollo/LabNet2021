
function validarNombre()

{
    var nombre = document.getElementById("id_nombre").value;

    if ((nombre == "" || !nombre))

    {

        

        alert("completar nombre, campo obligatorio");
        return false;

    }
    return true;

}

function validarApellido()

{
    var apellido = document.getElementById("id_apellido").value;

    if ((apellido == "" || !apellido))
    {
       

        alert("completar apellido campo obligatorio");
        return false;

    }

    return true;

}


function limpiarCampos()

{
    document.getElementById("id_nombre").value= "";
    document.getElementById("id_apellido").value="";
    document.getElementById("id_edad").value = "";
    document.getElementById("id_empresa").value = "";


    return true;


}