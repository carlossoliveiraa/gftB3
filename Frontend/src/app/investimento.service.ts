import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class InvestimentoService {

  private apiUrl = 'http://localhost:44385/api/CDB/calcular';  // Substitua pela URL correto da sua API

  constructor(private http: HttpClient) { }

  calcularInvestimento(orcamento: any): Observable<any> {
    return this.http.post<any>(this.apiUrl, orcamento).pipe(
      catchError(this.handleError)
    );
  }

  private handleError(error: HttpErrorResponse) {
    let errorMessage = 'Ocorreu um erro desconhecido!';
    if (error.status === 0) {     
      errorMessage = 'A API está indisponível. Por favor, verifique se a API está rodando.';
    } else {     
      errorMessage = `Erro ${error.status}: ${error.message}`;
    }
    return throwError(() => new Error(errorMessage));
  }
}
