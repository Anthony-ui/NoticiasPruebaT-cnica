const guardar = document.querySelector(`.guardar`);
const formulario = document.querySelector(`form`);






guardar.addEventListener("click", () => {


    registrar();
     
});


const registrar = async () => {

    console.log(guardar);
    guardar.disabled = true;
    let form = new FormData(formulario);
    const url = `../../Noticias/registrar`;
    let res = await axios.post(url, form);
    res = res.data;
    if (res == "ok") {

        guardar.disabled = false;
        Swal.fire({
            title: 'Noticias',
            text: "Guardado con Exito",
            icon: 'success',
            showCancelButton: false,
            confirmButtonColor: '#3085d6',
            confirmButtonText: 'Ok!'
        }).then((result) => {

            top.location.href ="../../Noticias/BackEnd"

        })
      

    }



}
