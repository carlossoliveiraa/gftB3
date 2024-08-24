import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { CalculoInvestimentoComponent } from './calculo-investimento/calculo-investimento.component';

const routes: Routes = [
  { path: '', component: CalculoInvestimentoComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    CalculoInvestimentoComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
