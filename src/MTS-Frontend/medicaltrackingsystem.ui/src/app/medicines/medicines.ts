import { DatePipe } from '@angular/common';
import { Timestamp } from 'rxjs/internal/operators/timestamp';

export interface Medicines
{
  fullNameOfMedicine : string;
  brand : string;
  price : any;
  quantity : number;
  expiryDate : Date;
  notes : string;
}
