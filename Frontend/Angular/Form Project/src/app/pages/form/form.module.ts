import { FormsModule } from '@angular/forms';
import { FormComponent } from './form.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

@NgModule({
    declarations: [FormComponent],
    imports: [ CommonModule, FormsModule ],
    exports: [FormComponent],
    providers: [],
})
export class FormModule {}
