//Função para atualizar em tempo real a média do aluno
function calculoMedia() {
    var logica = parseFloat(window.document.getElementById('logica').value) || 0;
    var EstrutDados = parseFloat(window.document.getElementById('EstrutDados').value) || 0;
    var POO = parseFloat(window.document.getElementById('POO').value) || 0;
    var Banco_de_Dados = parseFloat(window.document.getElementById('Banco_de_Dados').value) || 0;
    const desempenhoLabel = window.document.getElementById('result');

    var media = (logica + EstrutDados + POO + Banco_de_Dados) / 4;

    if (media >= 1 && media <= 6.99) {
        desempenhoLabel.textContent = "Baixo desempenho!";
        desempenhoLabel.style.color = "red";
        desempenhoLabel.style.fontWeight = "600";
    } else if (media >= 7 && media <= 8.99) {
        desempenhoLabel.textContent = "Ótimo desempenho!";
        desempenhoLabel.style.color = "#ff9800";
        desempenhoLabel.style.fontWeight = "600";
    } else if (media >= 9) {
        desempenhoLabel.textContent = "Excelente desempenho!";
        desempenhoLabel.style.color = "green";
        desempenhoLabel.style.fontWeight = "600";
    } else {
        desempenhoLabel.textContent = "Aguardando informações...";
        desempenhoLabel.style.color = "#4fa8fb";
        desempenhoLabel.style.fontWeight = "600";
    }

    window.document.getElementById('media').value = media.toFixed(2);
};

// Verificar o desempenho quando a página é carregada
calculoMedia();

//Adicionando eventos aos inputs
window.document.addEventListener('DOMContentLoaded', (event) => {
    window.document.getElementById('logica').addEventListener('blur', calculoMedia);
    window.document.getElementById('EstrutDados').addEventListener('blur', calculoMedia);
    window.document.getElementById('POO').addEventListener('blur', calculoMedia);
    window.document.getElementById('Banco_de_Dados').addEventListener('blur', calculoMedia);
});