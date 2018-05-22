document.addEventListener("DOMContentLoaded",
    function main(e) {

        ecraChampions();

    });

function mostraChampions(champion) {

    var divCham = document.getElementById("ListChamp");

    for (var i = 0; i < champion.length;i++) {
        var champ = champion[i];

        var Nome = document.createElement("p");

        Nome.textContent = champ.Nome;

        divCham.appendChild(Nome);
    }
}

function ecraChampions() {
    return getChampions()

        .then(function (champion) {

            mostraChampions(champion);
        })
        .catch(function (erro) {

            console.error(erro);
        });
}
