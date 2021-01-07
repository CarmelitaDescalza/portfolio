import { FormModule } from './form/form.module';
import { HomeModule } from './home/home.module';
import { NgModule } from '@angular/core';
import { LoginModule } from './login/login.module';
import { FormComponent } from './form/form.component';

@NgModule({
    declarations: [],
    imports: [LoginModule, HomeModule, FormModule],
    exports: [LoginModule, HomeModule, FormModule],
    providers: []
})

export class PagesModule {}
