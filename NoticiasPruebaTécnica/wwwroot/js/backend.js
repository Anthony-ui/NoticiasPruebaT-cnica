const contenido = document.querySelector(`.contenido`);

const cargarBackEnd = async () => {
   
    const url = `../../Noticias/noticiasBackEnd`;
    let html = ``;
    let res = await axios.get(url);
    res = res.data;
 
    console.log(res);

    res.forEach(item => {


        html +=


            `   <div class="card">
                  <div class="card-body ">
                       
                       <div class="row" >
                      <div class="col-sm-4 grid-margin">
                        <div class="position-relative">
                          <div class="rotate-img">
                            <img
                              src="../../${item.imagen}"
                              alt="thumb"
                              class="img-fluid"
                            />
                          </div>
                      
                        </div>
                      </div>
                      <div class="col-sm-8  grid-margin">
                        <h2 class="mb-2 font-weight-600">
                       ${item.titulo}
                        </h2>
                        <div class="fs-13 mb-2">
                          <span class="mr-2">Hora </span>${item.hora}
                        </div>
                        <p class="mb-0">
                         ${item.noticia}
                        </p>
                      </div>
                    </div >


                  </div>`;


    });
    contenido.innerHTML = html;










}

cargarBackEnd();



