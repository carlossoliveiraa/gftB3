import { TestBed } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { InvestimentoService } from './investimento.service';

describe('InvestimentoService', () => {
  let service: InvestimentoService;
  let httpMock: HttpTestingController;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],  // Certifique-se de importar o HttpClientTestingModule
      providers: [InvestimentoService]
    });
    service = TestBed.inject(InvestimentoService);
    httpMock = TestBed.inject(HttpTestingController);
  });

  afterEach(() => {
    httpMock.verify(); // Verifica se não há requisições pendentes
  });

  it('deve ser criado', () => {
    expect(service).toBeTruthy();
  });

  it('deve fazer uma chamada POST para calcular o investimento', () => {
    const mockOrcamento = { valorInicial: 1000, prazoMeses: 12 };
    const mockResponse = { ValorFinalBruto: 1200, Imposto: 100, ValorFinalLiquido: 1100 };

    service.calcularInvestimento(mockOrcamento).subscribe(response => {
      expect(response).toEqual(mockResponse);
    });

    const req = httpMock.expectOne(service['apiUrl']);
    expect(req.request.method).toBe('POST');
    req.flush(mockResponse); // Retorna o mockResponse como a resposta da chamada HTTP
  });

  it('deve retornar um erro se a API estiver fora do ar', () => {
    const mockOrcamento = { valorInicial: 1000, prazoMeses: 12 };

    service.calcularInvestimento(mockOrcamento).subscribe(
      () => fail('Deveria ter falhado com um erro de rede'),
      (error: Error) => {
        expect(error.message).toBe('A API está indisponível. Por favor, verifique se a API está rodando.');
      }
    );

    const req = httpMock.expectOne(service['apiUrl']);
    req.error(new ErrorEvent('Network error')); // Simula um erro de rede
  });
});
