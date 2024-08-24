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

  resultados: any[] = [];  
  warning: string = '';  

  constructor(private investimentoService: InvestimentoService) { }

  onSubmit() {   
    if (!this.orcamento.valorInicial || !this.orcamento.prazoMeses) {
      this.warning = 'Todos os campos são obrigatórios. Por favor, preencha o valor inicial e o prazo em meses.';
      return;  
    }

    this.warning = '';  

    console.log('Enviando dados:', this.orcamento);
    this.investimentoService.calcularInvestimento(this.orcamento).subscribe(
      data => {
        console.log('Dados recebidos:', data);
        this.resultados.push(data);  
    
        this.orcamento.valorInicial = '';
        this.orcamento.prazoMeses = '';
      },
      error => {      
        console.error('Erro ao calcular investimento', error);
        this.warning = 'A API está indisponível. Por favor, verifique se a API está rodando.';  
      }
    );
  }
}
