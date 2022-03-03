
const contenido = document.querySelector(`.contenido`);
    
const cargarRemotas = async () => {


    const url = `https://gnews.io/api/v4/search?q=example&token=c5f0bf642ea5d503c0713a3097e87ee6`;
    let html=``;
    let res = await axios.get(url);
    res = res.data.articles;
 


    res.forEach(item => {

     
        html += 


            `   <div class="card">
                  <div class="card-body ">
                       
                       <div class="row" >
                      <div class="col-sm-4 grid-margin">
                        <div class="position-relative">
                          <div class="rotate-img">
                            <img
                              src="${item.image}"
                              alt="thumb"
                              class="img-fluid"
                            />
                          </div>
                          <div class="badge-positioned">
                            <span class="badge badge-danger font-weight-bold"
                              >Flash news</span
                            >
                          </div>
                        </div>
                      </div>
                      <div class="col-sm-8  grid-margin">
                        <h2 class="mb-2 font-weight-600">
                       ${item.title}
                        </h2>
                        <div class="fs-13 mb-2">
                          <span class="mr-2">Photo </span>${item.publishedAt}
                        </div>
                        <p class="mb-0">
                         ${item.content}
                        </p>
                      </div>
                    </div >


                  </div>`;


    });
    contenido.innerHTML = html;



   






}

cargarRemotas();



