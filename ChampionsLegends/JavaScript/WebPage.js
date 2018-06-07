document.addEventListener("DOMContentLoaded", function main(e) {
    ini();
    //barraProcura ();
});


function ini() {

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

    var Champ = document.getElementById("Champ").addEventListener("click", function (e) {

        //e.preventDefault();
        var div2 = document.getElementById("div2");

        div2.classList.add("hidden");
        containerChamp.classList.remove("hidden");
        containerChamp.innerHTML = "";

        ecranChamps();
    });

    var leagueIcon = document.getElementById("leagueIcon").addEventListener("click", function (e) {

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

function mostraChamps(champs) {

    var containerChamp = document.getElementById("containerChamp");

    var container = document.createElement("div");
    container.className = "col-md-9";

    for (var i = 0; i < champs.length; i++) {
        var champ = champs[i];

        var divTexto = document.createElement("div");
        var nome = document.createElement("p");
        var id = document.createElement("p");
        id.textContent = champ.Id;
        console.log(id);
        nome.textContent = champ.Nome;

        var fotoChamp = document.createElement("img");
        fotoChamp.setAttribute("src", champ.Foto);
        fotoChamp.setAttribute("title",champ.Nome);
        fotoChamp.className = "img-categories";

        fotoChamp.addEventListener("click", function () {
            container.classList.add("hidden");
            getChampion(champ.Id).then(function(result) {


                mostraDetalhes(result);
            })                            
            .catch(function(erro) {
                console.error(erro);
                alert("Lamentamos, mas ocorreu um erro...");

            });

        });
        container.appendChild(fotoChamp);
        containerChamp.appendChild(container);
    }
}

function mostraDetalhes(champId) {

    var detalheChamp = document.getElementById("detalheChamp");


    var Nome = document.createElement("p");
    Nome.textContent = champId.Nome;

    detalheChamp.appendChild(Nome);
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