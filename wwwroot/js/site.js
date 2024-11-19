function calculoMedia() {
    var logica = parseFloat(window.document.getElementById('logica').value) || 0;
    var EstrutDados = parseFloat(window.document.getElementById('EstrutDados').value) || 0;

    var media = (logica + EstrutDados) / 2;

    window.document.getElementById('media').value = media;
};

//Adicionando eventos aos inputs
window.document.addEventListener('DOMContentLoaded', (event) => {
    window.document.getElementById('logica').addEventListener('blur', calculoMedia);
    window.document.getElementById('EstrutDados').addEventListener('blur', calculoMedia);
});