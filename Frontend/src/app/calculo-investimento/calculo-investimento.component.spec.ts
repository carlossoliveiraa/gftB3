import { ComponentFixture, TestBed } from '@angular/core/testing';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { CalculoInvestimentoComponent } from './calculo-investimento.component';
import { InvestimentoService } from '../investimento.service';
import { of } from 'rxjs';

describe('CalculoInvestimentoComponent', () => {
  let component: CalculoInvestimentoComponent;
  let fixture: ComponentFixture<CalculoInvestimentoComponent>;
  let investimentoService: InvestimentoService;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      declarations: [CalculoInvestimentoComponent],
      providers: [InvestimentoService]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CalculoInvestimentoComponent);
    component = fixture.componentInstance;
    investimentoService = TestBed.inject(InvestimentoService);
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should call calcularInvestimento on submit with valid data', () => {
    const spy = spyOn(investimentoService, 'calcularInvestimento').and.returnValue(of({}));
       
    component.orcamento = {
      valorInicial: '2000',
      prazoMeses: '12'
    };

    component.onSubmit();

    expect(spy).toHaveBeenCalled();  
  });

  it('should not call calcularInvestimento on submit with invalid data', () => {
    const spy = spyOn(investimentoService, 'calcularInvestimento').and.returnValue(of({}));
    
     
    component.orcamento = {
      valorInicial: '',
      prazoMeses: ''
    };

    component.onSubmit();

    expect(spy).not.toHaveBeenCalled();  
    expect(component.warning).toBe('Todos os campos são obrigatórios. Por favor, preencha o valor inicial e o prazo em meses.');
  });
});
