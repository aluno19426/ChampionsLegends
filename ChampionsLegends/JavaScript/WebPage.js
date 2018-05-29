document.addEventListener("DOMContentLoaded", function main(e) {
    ini();
});


function ini(){

    var nav = document.getElementById("nav");
    var main = document.getElementById("main");
    var div2 = document.getElementById("div2");
    var containerChamp = document.getElementById("containerChamp");

    nav.classList.add("hidden");
    main.classList.add("hidden");
    div2.classList.add("hidden");
    containerChamp.classList.add("hidden");

    nav.classList.remove("hidden");
    main.classList.remove("hidden");
    div2.classList.remove("hidden");

    var Champ = document.getElementById("Champ").addEventListener("click",function(e){

        //e.preventDefault();
        var div2 = document.getElementById("div2");

        div2.classList.add("hidden");
        containerChamp.classList.remove("hidden");
        containerChamp.innerHTML = "";

        ecranChamps();
    });

    var leagueIcon = document.getElementById("leagueIcon").addEventListener("click",function(e){

        var nav = document.getElementById("nav");
        var main = document.getElementById("main");
        var div2 = document.getElementById("div2");
        var containerChamp = document.getElementById("containerChamp");
        
        nav.classList.add("hidden");
        main.classList.add("hidden");
        div2.classList.add("hidden");
        containerChamp.classList.add("hidden");
    
        nav.classList.remove("hidden");
        main.classList.remove("hidden");
        div2.classList.remove("hidden");

    });
}

function mostraChamps(champs)  {

    var containerChamp = document.getElementById("containerChamp");

    var container = document.createElement("div");
    container.className = "col-md-9";

    for (var i = 0; i < champs.length; i++) {
        var champ = champs[i];

        var divTexto = document.createElement("div");
        var nome = document.createElement("p");
        nome.textContent = champ.Nome;
        
        var fotoChamp = document.createElement("img");
        fotoChamp.setAttribute("src",champ.Foto);
        fotoChamp.className = "img-categories";  

        //divChamp.appendChild(fotoChamp);
        container.appendChild(fotoChamp);
        containerChamp.appendChild(container);

        containerChamp.addEventListener("mouseover",function(e){

            divTexto.appendChild(nome);
            containerChamp.appendChild(divTexto);
        });
    }
}

function ecranChamps() {

    return getChampions()

        .then(function (champs) {

            mostraChamps(champs);
        })
        .catch(function (erro) {

            console.error(erro);
        });
}


function toggle () {

    

}