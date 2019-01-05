
function clickEmpleado() {

    $.ajax({
        type: "GET",
        url: "https://localhost:44323/Empleado/GetEmpleadoByID/" + $("#IdEmpleado").val(),
        async: false,
        success: function (data) {
            /* Supongamos que #contenido es el tbody de tu tabla */
            /* Inicializamos tu tabla */
            $("#tbody").empty();
            /* Vemos que la respuesta no este vacía y sea una arreglo */
            console.log(data);
            if (data != null) {
                /* Recorremos tu respuesta con each */
                //$.each(data, function (index, value) {
                  //  console.log(value);
                    /* Vamos agregando a nuestra tabla las filas necesarias */
              //  $("#table").show();
                $("#tbody").append("<tr><td>" + data.id + "</td><td>" + data.name + "</td><td>" + data.contractTypeName + "</td><td>" + data.roleId + "</td><td>" + data.roleName + "</td><td>" + data.roleDescription + "</td><td>" + data.hourlySalary + "</td><td>" + data.monthlySalary + "</td><td>" + data.salario + "</td></tr>");
                //});
            }   
            console.log(data);
        },
        error: function (data) {
            console.log(data);
        },
        
    });
}


function clickEmpleadoTodos() {

    $.ajax({
        type: "GET",
        url: "https://localhost:44323/Empleado/GetEmpleados",
        async: false,
        //dataType: "application/json; charset=utf-8",
        success: function (data) {
            /* Supongamos que #contenido es el tbody de tu tabla */
            /* Inicializamos tu tabla */

            $("#tbody").empty();
            /* Vemos que la respuesta no este vacía y sea una arreglo */
            console.log(data);
            if (data != null && $.isArray(data)) {
                /* Recorremos tu respuesta con each */
                $.each(data, function (index, value) {
                    console.log(value);
                    /* Vamos agregando a nuestra tabla las filas necesarias */
                   // $("#table").show();
                    $("#tbody").append("<tr><td>" + value.id + "</td><td>" + value.name + "</td><td>" + value.contractTypeName + "</td><td>" + value.roleId + "</td><td>" + value.roleName + "</td><td>" + value.roleDescription + "</td><td>" + value.hourlySalary + "</td><td>" + value.monthlySalary + "</td><td>" + value.salario + "</td></tr>");

                });
            }   
            console.log(data);
        },
        error: function (data) {
         
            console.log(data);
        },
        //contentType: "application/json; charset=utf-8",

    });
}