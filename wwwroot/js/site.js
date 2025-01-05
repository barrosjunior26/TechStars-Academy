// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



var mediaGeral = window.document.getElementsByClassName(".mediaGeral");

$(document).ready(function () {

	setTimeout(function () {
		$(".alert").fadeOut("slow", function () {
			$(this).alert("close");
		});
	}, 5000);

	//Adicionar mais linhas a tabela
	$(document).on("click", ".addLinha", function () {
		var adicionarNovaLinha =
			`
            <tr>
				<td>
					<select class="form-control">
						<option selected disabled value="">Selecione</option>
						<option value="Fundamentos de Computação">Fundamentos de Computação</option>
						<option value="Desenvolvimento de Software">Desenvolvimento de Software</option>
						<option value="Infraestrutura e Sistemas Operacionais">Infraestrutura e Sistemas Operacionais</option>
						<option value="Tecnologias e Ferramentas">Tecnologias e Ferramentas</option>
						<option value="Matemática e Estatística">Matemática e Estatística</option>
						<option value="Soft Skills e Gestão">Soft Skills e Gestão</option>
					</select>
				</td>
				<td>
					<input type="text" class="form-control notaInput"  maxlength="4"/>
				</td>
				<td>
					<button type="button" class="btn btn-danger removerLinha"><i class="bi bi-file-earmark-x-fill"></i></button>
				</td>
			</tr>
            `;
		$("#tabelaDinamica tbody").append(adicionarNovaLinha);
	});
	//Remover linha da tabela
	$(document).on("click", ".removerLinha", function () {
		$(this).closest("tr").remove();
		calculaMedia(); //Recalcula a média quando uma linha é removida da tabela
	});

	//Recalcula a média a medida que as notas forem alteradas
	$(document).on("input", ".notaInput", function () {
		calculaMedia();
	});

	function calculaMedia() {
		var totalNotas = 0;
		var quantidadeLinhas = 0;

		$(".notaInput").each(function () {
			var nota = parseFloat($(this).val());
			if (!isNaN(nota)) { //Verifica se o valor digitado é válido
				totalNotas += nota;
				quantidadeLinhas++
			};
		});

		var media = quantidadeLinhas > 0 ? (totalNotas / quantidadeLinhas).toFixed(2) : "Carregando...";

		$(".mediaGeral").val(media)
	};
});



