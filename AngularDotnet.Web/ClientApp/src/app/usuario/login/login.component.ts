import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../model/usuario";
import { ActivatedRoute, Router } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {
  public usuario;
  public returnUrl: string;

  constructor(private router: Router, private activatedRouter: ActivatedRoute,
    private usuarioServico: UsuarioServico) {
  }
    ngOnInit(): void {
      this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
      this.usuario = new Usuario();
    }

  entrar() {
    this.usuarioServico.verificaUsuario(this.usuario)
      .subscribe(
        data => {

        },
        err => {

        }
      );
    /*if (this.usuario.email == "email@teste.com" && this.usuario.senha == "abc123") {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate([this.returnUrl]);
    }*/
  }
}
