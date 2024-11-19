//Função para atualizar em tempo real a média do aluno
function calculoMedia() {
    var logica = parseFloat(window.document.getElementById('logica').value) || 0;
    var EstrutDados = parseFloat(window.document.getElementById('EstrutDados').value) || 0;
    var POO = parseFloat(window.document.getElementById('POO').value) || 0;
    var Banco_de_Dados = parseFloat(window.document.getElementById('Banco_de_Dados').value) || 0;

    var media = (logica + EstrutDados + POO + Banco_de_Dados) / 4;

    window.document.getElementById('media').value = media.toFixed(2);
};

//Adicionando eventos aos inputs
window.document.addEventListener('DOMContentLoaded', (event) => {
    window.document.getElementById('logica').addEventListener('blur', calculoMedia);
    window.document.getElementById('EstrutDados').addEventListener('blur', calculoMedia);
    window.document.getElementById('POO').addEventListener('blur', calculoMedia);
    window.document.getElementById('Banco_de_Dados').addEventListener('blur', calculoMedia);
});