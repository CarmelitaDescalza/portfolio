import { CarouselModule } from './../../components/carousel/carousel.module';
import { ReverseStr } from './../../pipes/reverse.pipe';
import { CardModule } from './../../components/card/card.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login.component';
import {FormsModule} from '@angular/forms';

@NgModule({
    declarations: [LoginComponent, ReverseStr],
    imports: [ CommonModule, CardModule, FormsModule, CarouselModule ],
    exports: [
        LoginComponent
    ],
    providers: [],
})
export class LoginModule {}
