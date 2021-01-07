import { Injectable } from '@angular/core';

@Injectable()
export class FormService {

    public getMeFormService(form: any) {
        console.log ('El formulario fué enviado');
        console.log(form);
    }

}
