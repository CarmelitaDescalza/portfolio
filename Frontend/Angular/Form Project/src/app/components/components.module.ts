import { CarouselModule } from './carousel/carousel.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardModule } from './card/card.module';


@NgModule({
    declarations: [],
    imports: [ CommonModule, CardModule, CarouselModule ],
    exports: [CardModule, CarouselModule],
    providers: [],
})
export class ComponentsModule {}
