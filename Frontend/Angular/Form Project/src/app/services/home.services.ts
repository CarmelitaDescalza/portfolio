import { Injectable } from '@angular/core';

@Injectable()
export class HomeService {

    public contactForm: string;

    public sendFormContact(formulario: any) {
        console.log ('El formulario fué enviado');
        console.log (formulario.form.value);
        this.contactForm = formulario.form.value;
    }

    public getContact() {
        return this.contactForm;

    }
}
