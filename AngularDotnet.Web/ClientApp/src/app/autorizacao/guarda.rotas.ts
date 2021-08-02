import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";

@Injectable({
  providedIn:'root'
})

export class GuardaRotas implements CanActivate {

  //declaração da variável de forma implícita
  constructor(private router: Router) {
    
  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    let autenticado = sessionStorage.getItem("usuario-autenticado");
    if (autenticado == "1") {
      return true;
    }

    this.router.navigate(['/entrar'],
      {
        queryParams: {
          returnUrl: state.url
        }
      });
    //se usuario estiver autenticado retorna verdadeiro
        //fixo por enquanto
    return false;
  }
    
}
