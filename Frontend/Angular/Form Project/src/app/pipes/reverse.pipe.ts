import {Pipe, PipeTransform} from '@angular/core';
@Pipe({name: 'reversed'})

export class ReverseStr implements PipeTransform {
    transform(value: string): string {
        let newStr: string = '';
        for (let i = value.length - 1; i  >= 0; i--) {
            newStr += value.charAt(i);
        }
        return newStr;
    }
}

