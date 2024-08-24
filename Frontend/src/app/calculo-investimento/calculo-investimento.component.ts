import { Component } from '@angular/core';
import { InvestimentoService } from '../investimento.service';

@Component({
  selector: 'app-calculo-investimento',
  templateUrl: './calculo-investimento.component.html', 
  styleUrls: ['./calculo-investimento.component.css']
})
export class CalculoInvestimentoComponent {
  orcamento = {
    valorInicial: '',
    prazoMeses: ''
  };

  resultados: any[] = [];  // Armazena todos os resultados dos cálculos
  warning: string = '';  // Variável para controlar a exibição do aviso

  constructor(private investimentoService: InvestimentoService) { }

  onSubmit() {
    // Verifica se os campos estão preenchidos
    if (!this.orcamento.valorInicial || !this.orcamento.prazoMeses) {
      this.warning = 'Todos os campos são obrigatórios. Por favor, preencha o valor inicial e o prazo em meses.';
      return;  // Não prossegue com o envio
    }

    this.warning = '';  // Oculta a mensagem de aviso se os campos estiverem preenchidos

    console.log('Enviando dados:', this.orcamento);
    this.investimentoService.calcularInvestimento(this.orcamento).subscribe(
      data => {
        console.log('Dados recebidos:', data);
        this.resultados.push(data);  // Adiciona o novo resultado à lista de resultados

        // Limpar os campos do formulário após o envio
        this.orcamento.valorInicial = '';
        this.orcamento.prazoMeses = '';
      },
      error => {      
        console.error('Erro ao calcular investimento', error);
        this.warning = 'A API está indisponível. Por favor, verifique se a API está rodando.';  // Define a mensagem de erro
      }
    );
  }
}
