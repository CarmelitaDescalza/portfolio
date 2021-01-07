import { NgForm } from '@angular/forms';
import { FormService } from './../../services/form.services';
import { ContactForm } from './../../models/contactForm';
import { Component, OnInit } from '@angular/core';
import { isNullOrUndefined } from 'util';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css'],
  providers: [ FormService]
})
export class FormComponent implements OnInit {

  // Instanciamos de la clase modelo //
  contactModel = new ContactForm ();

  // Variables del objeto formulario //
  public newContact1: string;
  public newContact2: string;

  // Valor del name //
  public newContact3: string;
  // Valor del surname //
  public newContact4: string;
  // Valor del email //
  public newContact5: string;
  // Valor del thelephone //
  public newContact6: string;
  // Valor del password //
  public newContact7: string;



  // Valores del password //
  public newContactPassword1: string;
  public newContactPassword2: string;

  // Valor del checkBox //
  public newContactCheckbox: string;

  // Variables de warning //

  public warning: boolean;
  public warning1: boolean;

  public warning11: boolean;
  public warning12: boolean;
  public warning13: boolean;
  public warning14: boolean;
  public warning15: boolean;

  public warningText: string;
  public warningText1: string;
  public warning2: boolean;
  public warningText2: string;
  public warning3: boolean;
  public warningText3: string;

  // Variable de texto de error //

  public error: string = 'There is some error in the form : ';
  public error1: string = 'Please, review the form and complete the requerided fields';
  public error2: string = 'Error Password. The password must be the same in both fields';
  public error3: string = 'Accept the terms to continue ';

  // Variables de error para marcar los campos cuando salta el warning1

  public errorName: boolean;
  public errorSurname: boolean;
  public errorEmail: boolean;
  public errorTelephone: boolean;
  public errorPassword: boolean;

  public errorPassword2: boolean;
  public errorCheckbox: boolean;



  // Instanciamos de la clase servicio dentro del constructor //
  // Inicializamos la variable newContact string sin nada de momento //
  // Inicializamos la variable de warning en false que para mi sinfinica of o 0 //
  // Inicializamos la variable de ErrorName en false que para mi sinfinica of o 0 //

  constructor(
    private formService: FormService
  ) {
      this.newContact1 = '';
      this.warning = false;
      this.warning1 = false;

      this.warning11 = false;
      this.warning12 = false;
      this.warning13 = false;
      this.warning14 = false;
      this.warning15 = false;

      this.warningText1 = '';
      this.errorName = false;
      this.errorSurname = false;
      this.errorEmail = false;
      this.errorTelephone = false;
      this.errorPassword = false;

      this.warning2 = false;
      this.warning3 = false;
      this.errorCheckbox = false;
      this.errorPassword2 = false;


   }

  ngOnInit() {
  }

  // Este método se activa al apretar el botón de enviar del formulario y debe recibir una variable tipo NGForm para ejecutarse
  // Dentro hemos metido una función que se ejecuta desde una instancia del servicio FromService,
  // función que saca por consola la variable que recibe.
  onSubmit( f: NgForm) {
    this.formService.getMeFormService( f );

    // Con este console.log comprobaremos que podemos hacer lo mismo que lo que hacemos desde el servicio. Efectivamente.
    console.log (f);
    console.log ( 'Hace lo mismo que el servicio. Efectivamente' );

    // Ahora quiero sacar a unas variables este objeto
    // Primero a un srting en el que obtenemos los valores del formulario.

    //  El objetivo es imprimir en la vista esta variable, al ejecutarse esta función el string adquiere valor:

    // Primero probamos así  y obtenemos [object Object] en la impresora
    this.newContact1 = f.form.value;
    console.log ('Valor1 : ' + this.newContact1);

    // Luego lo hacemos así y transformamos JSON en string
    this.newContact2 = JSON.stringify(f.form.value) ;
    console.log ('Valor2 : ' + this.newContact2);

    //  Podemos obtener el valor del formulario que queramos así:
    this.newContact3 = JSON.stringify(f.form.value.name) ;
    console.log ('Valor3 name : ' + this.newContact3);


    //////////  Identificar errores del formulario  /////////

    //  Crearemos una variable que contenga el texto que nos informará de error, warningText: string;
    //  otra que sacará esta infoemación por la vista error:string;
    //  y una boleana que activará este texto de error llamada warning: boollean;//

    this.warningText = this.error;

    //    ERROR1 CAMPOS REQUERIDOS //
    //  Comprobaremos ahora que si quisieramos trabajar con este valor podríamos.
    //  Crearemos para ello otra variable que será nuestra condicional de warning1,
    // esta estará apagada en false y si hay algún error de tipo CAMPOS REQUERIDOS se encenderá en true.

    //// name ////

    if (((this.newContact3) === ((undefined)) || ( (this.newContact3.length <= 4) )  )) {

      this.warning11 = true;
      this.errorName = true;

    } else {

      this.warning11 = false;
      this.errorName = false;
    }

    console.log ('Valor de warning : ' + this.warning1);

    // Crearemos otra variable que contendrá el valor del texto de error que irá cambiando
    // Y que se activará en la vista cuando el warning1 se active

    this.warningText1 = this.error1;

    // Crearemos otra variable boolean que activará una clase especial de error para cada campo del fromulario
    //   this.errorName = false; Esta variable se activa en el condicional de if si está sin rellenar el campo, lineas arriba.
    //  Vemos su valor tambien por consola para tener control.
    console.log ('Valor de ErrorName : ' + this.errorName);

    //  control error name
    console.log ('---Valor de warningName : ' + this.warning);
    console.log ('---Valor de warning1 : ' + this.warning1);
    console.log ('---Valor de warning1 : ' + this.warning11);


    //// surname ////

    // crearemos la variable que contendrá el valor del surmame1 que es el obligatorio
    this.newContact4 = JSON.stringify(f.form.value.surname1) ;

    console.log ('Valor de newContact4 : ' +  this.newContact4);

    //  creareos una varible distinta que activará el cambio de estilo en el campo de apellidos cuanda haya error //

    if (((this.newContact4) === ((undefined)) || ( (this.newContact4.length <= 4) )  )) {

      this.warning12 = true;
      this.errorSurname = true;

    } else {

      this.warning12 = false;
      this.errorSurname = false;
    }

    //  control error surname
    console.log('---Valor de warningSurname : ' + this.warning);
    console.log('---Valor de warning1 : ' + this.warning1);
    console.log ('---Valor de warning1 : ' + this.warning12);
   
          //// telephone ////

    // crearemos la variable que contendrá el valor del telephone
    this.newContact5 = JSON.stringify(f.form.value.telephone) ;

    console.log ('Valor de telephone : ' +  this.newContact5);

    //  creareos una varible distinta que activará el cambio de estilo en el campo de telephone cuanda haya error //

    if (((this.newContact5) === ((undefined)) || ( (this.newContact5.length <= 4) )  )) {

      this.warning13 = true;
      this.errorTelephone = true;

    } else {

      this.warning13 = false;
      this.errorTelephone = false;
    }

    //  control error telephone
    console.log('---Valor de warningTelephone : ' + this.warning);
    console.log('---Valor de warning1 : ' + this.warning1);
    console.log ('---Valor de warning1 : ' + this.warning13);

        //// email ////

    // crearemos la variable que contendrá el valor del email
    this.newContact6 = JSON.stringify(f.form.value.email) ;

    console.log ('Valor de email : ' +  this.newContact6);

    //  creareos una varible distinta que activará el cambio de estilo en el campo de email cuanda haya error //

    if (((this.newContact6) === ((undefined)) || ( (this.newContact6.length <= 4) )  )) {

      this.warning14 = true;
      this.errorEmail = true;

    } else {

      this.warning14 = false;
      this.errorEmail = false;
    }

    //  control error email
    console.log('---Valor de warningEmail : ' + this.warning);
    console.log('---Valor de warning1 : ' + this.warning1);
    console.log ('---Valor de warning1 : ' + this.warning14);

          //// password ////

    // crearemos la variable que contendrá el valor del password
    this.newContact7 = JSON.stringify(f.form.value.password) ;

    console.log ('Valor de password : ' +  this.newContact7);

    //  creareos una varible distinta que activará el cambio de estilo en el campo de password cuanda haya error //

    if (((this.newContact7) === ((undefined)) || ( (this.newContact7.length <= 2) )  )) {

      this.warning15 = true;
      this.errorPassword = true;

    } else {

      this.warning15 = false;
      this.errorPassword = false;
    }

    //  control error email
    console.log('----Valor de warningPassword : ' + this.warning);
    console.log('---Valor de warning1 : ' + this.warning1);
    console.log ('---Valor de warning1 : ' + this.warning15);

    console.log ('Valor de ErrorPassword : ' +  this.errorPassword);

    //    ERROR2 PASSWORD DISTINTO //

    // Crearemos las variables que contienen los valores de los campos del Paswword y les daremos el valor que cogemos del formulario
    // La condicion por la que aparecerá el error
    //  Y las variables que activarán el warninig, el error y contendrán el texto de error

    this.newContactPassword1 = JSON.stringify(f.form.value.password);
    this.newContactPassword2 = JSON.stringify(f.form.value.password2);

    console.log ('Password1 : ' + this.newContactPassword1);
    console.log ('Password2 : ' + this.newContactPassword2);

    if ((this.newContactPassword1) !== (this.newContactPassword2)) {

      this.warning2 = true;
      this.errorPassword2 = true;

    } else {

      this.warning2 = false;
      this.errorPassword2 = false;
    }

    this.warningText2 = this.error2;

    //    ERROR3 ACEPTAR TERMINOS //

    //  Crearemos una variable que contiene el valor del checkbox
    this.newContactCheckbox = JSON.stringify(f.form.value.checkbox);
    console.log ('Valor del Checkbox : ' + this.newContactCheckbox);

    //  Crearemos otra variable que será nuestra condicional de warning2, una booleana,
    //  esta estará inicializada en false y si hay algún error de tipo Aceptar Terminos se encenderá en true: this.warning3 = false;
    //  Creamos la condicion con la que se encenderá este warning
    //  Si se cumple la condición se encenderá el warning3 y se activará tambien un texto de error



    if (((this.newContactCheckbox) === (undefined)) || ( (this.newContactCheckbox)  ===  ('false') )) {

      this.warning3 = true;
      this.errorCheckbox = true;
    } else {
      this.warning3 = false;
      this.errorCheckbox = false;
    }

    console.log ('Valor de Warning3 : ' + this.warning3);

   //  Crearemos las variables que contiene el texto de error:  public error3: string = 'Accept the terms to continue ';
   //   Y la variable que pinta este texto en la vista this.warningText3: string;

   //  En este caso igualaremos ambos strings

    this.warningText3 = this.error3;

   // Crearemos otra variable boolean que activará una clase especial de error para cada campo del checkbox
   // Veremos el valor de esta boolean
    console.log ('Valor de errorCheckbox : ' + this.errorCheckbox);


     //// warning 1 ////
    // La variable de warning1 será true si alguna de las otras warning11, 12, 13,14,15 es true
    if ( ( this.warning11 === true ) || (this.warning12 === true) || (this.warning13 === true)
     || (this.warning14 === true) || (this.warning15 === true) ) {
      this.warning1 = true;
  } else {
    this.warning1 = false;
  }



    //// warning general ////
    // La variable de warning será true si alguna de las otras warning1, 2 o 3, es true
    if ( ( this.warning1 === true ) || (this.warning2 === true) || (this.warning3 === true) ) {
        this.warning = true;
    } else {
      this.warning = false;
    }

    console.log ('---Valor de warningFinal : ' + this.warning);
    console.log ('---Valor de warning1 : ' + this.warning1);

    }


}
