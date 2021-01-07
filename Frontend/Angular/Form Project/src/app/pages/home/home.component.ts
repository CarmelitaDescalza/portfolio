import { HomeService } from './../../services/home.services';
import { ContactForm } from './../../models/contactForm';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css'],
    providers: [ HomeService]
})
export class HomeComponent implements OnInit {

    ContactModel = new ContactForm();

    datesForm: any;

    public warning: boolean;

    public msgError: string;


    constructor(
        private homeService: HomeService
    ) {
        this.warning = false;
        this.msgError = 'Error';
     }

    ngOnInit(): void {
        this.warning = false;
     }

     // Función que se activa al hacer click en el botón de tipo submit y que le hemos dicho que reciba el formulario, en la vista,
     // en la etiqueta <form hemos metido el evento de (NgSubmit)="onSubmit(contactForm)"
    onSubmit( f: NgForm) {

        // Si pasamos de todo lo de despues aquí vemos qué recibe del ngForm, es un objeto tipo NgForm //
        console.log('Esto es el formulario: ' + f);
        // Un objeto tipo NgForm //
        console.log('Esto es el formulario: ' + f);


        // Mediante esta función mandamos los datos al servicio //
        this.homeService.sendFormContact (f);

        this.homeService.getContact();


        this.getContactService();

        console.log ('El pueblo es:' + this.ContactModel.city);
        if ((this.ContactModel.password) === (this.ContactModel.password2)) {
            console.log('ok');
            this.warning = false;
            console.log(this.warning);
        } else {
            console.log('no');
            this.warning = true;
            console.log(this.warning);
        }
     }

     /*

     public controlForm(): void {
        if ((this.ContactModel.password) === (this.ContactModel.password2) ) {
                this.warning = true;
        } else {
            this.warning = false;
        }
     }
     */

     public getContactService(): void {
         this.datesForm = JSON.stringify(this.homeService.getContact()) ;
     }

}
