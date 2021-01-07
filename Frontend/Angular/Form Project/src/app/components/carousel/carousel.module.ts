import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CarouselComponent } from './carousel.component';

@NgModule({
    declarations: [CarouselComponent],
    imports: [ CommonModule ],
    exports: [CarouselComponent],
    providers: [],
})
export class CarouselModule {}
