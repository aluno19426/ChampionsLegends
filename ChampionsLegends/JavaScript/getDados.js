//vai buscar o valor getChampions
function getChampions() {

    var champions = "http://localhost:26012/api/champions";

    return fetch(champions, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            debugger;
            if (resposta.status === 200) {

                return resposta.json();

            } else {
                return Promise.reject(new Error("Erro ao obter categorias"));
            }
        });
}
