import { PruebaService } from './../../services/prueba.service';
import { Component, OnInit, OnDestroy } from '@angular/core';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css'],
    providers: [PruebaService]
  })



export class LoginComponent implements OnInit, OnDestroy {

  public title: string;
  public titleLogin: boolean;
  public msgUsuario: string;
  public msgUsuario1: string;

  public usuario: string;
  public password: string;

  public validatePassword: boolean;

  public arrayCoches: Array<string>;

  // Crearemos las variables tipos de formatos para pipe de Angular //

  public dataCurrency: number = 456;
  public dataDate = new Date (1991, 3, 29);
  public dataDecimal: any = 456.5456;
  public dataJson = {foo: 'foo', goo: {too: 'new'}};
  public dataString: string = 'Prueba';
  public dataPercent: number = 456;
  public dataSlice: Array<number> = [ 1, 2 , 3 , 4 , 5 , 6 ];

  constructor(
    // Objeto del Service //
    private pruebaService: PruebaService
  ) {
    this.title = 'Este es nuestro login';
    this.titleLogin = true;
    this.msgUsuario1 = 'El usuario debe tener más de 6 caracteres';
    this.validatePassword = false;
    this.arrayCoches = ['Renault Kangoo',  'Mercedes Citan' , 'Volswaguen Cadi', 'For Transit' ,
    'Volswaguen Transporter', 'Volswaguen Crafter'];

  }

  ngOnInit() {
    console.log ('El componente se ha inicializado');
    this.getUsersService();
  }
  ngOnDestroy() {
    console.log ('El componente se ha cerrado');
  }

  public envioLogin(): void {
    alert('Login Enviado Guapisima');
    // Esta alerta es una prueba //
    if (this.usuario.length < 6) {
      alert(this.msgUsuario1);
      }
      // Esta parte del códig corresponde al ngIf //
    if (this.password.length < 6 ) {
      this.validatePassword = true;
    } else {
      this.validatePassword = false;
    }
    console.log('El usuario es : ' + this.usuario + ' , la contraseña es : ' + this.password + ' .');
  }

  public validateEmail(evento): void {

    const valueImput: string = evento.target.value;

   /*
    console.log(valueImput);

    if (this.usuario.length < 6) {
    alert(this.msgUsuario1);
    }
    */
    this.msgUsuario = valueImput;

  }

  public getUsersService(): void {
    console.log('Usuarios son : ' + JSON.stringify(this.pruebaService.getUsers()));
  }

}
