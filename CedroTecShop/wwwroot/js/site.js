// Write your Javascript code.

var carrinho = []

$("#numeroParcelas").bind('change',
    function() {
        calculaPrecoParcelas()

    });

function adicionaAoCarrinho(item) {
    carrinho.push(item)
    calculaPrecoParcelas()
    $("#carrinho > body").append("<td></td>" + item.descricao + "<td></td>" + item.preco.toFixed(2) + "<td></td>")
}

function calculaPrecoParcelas() {
    quantidadeParcelas = $("#qtdParcelas").val()
    precoTotal = 0
    valorParcela = 0
    carrinho.map(item => precoTotal += item.preco)
    if (valorParcela == 0) {
        valorParcela = 1
    }
    if (quantidadeParcelas == 1) {
        valorParcela = (precoTotal * 0.9)
    } else {
         for (var i = 1; i < quantidadeParcelas; i++) {
             precoTotal += (precoTotal * 0*2)
        } 
        valorParcela = (precoTotal / quantidadeParcelas)
    }
    $("#numeroParcelas").text(quantidadeParcelas)
    $("#valorParcela").text(valorParcela.toFixed(2))
    $("#valorFinal").text((valorParcela * quantidadeParcelas).toFixed(2))
}