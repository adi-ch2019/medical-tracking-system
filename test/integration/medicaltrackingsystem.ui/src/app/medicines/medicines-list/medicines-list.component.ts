import { Component, OnInit } from '@angular/core';
import { Medicines } from '../medicines';
import {MedicinesService} from '../medicines.service';

@Component({
  selector: 'pm-medicines-list',
  templateUrl: './medicines-list.component.html',
  styleUrls: ['./medicines-list.component.css']
})
export class MedicinesListComponent implements OnInit {
  pageTitle = 'Medicines List';
  imageWidth = 50;
  imageMargin = 2;
  showImage = false;
  errorMessage = '';
  _listFilter = '';
  get listFilter(): string {
    return this._listFilter;
  }
  set listFilter(value: string) {
    this._listFilter = value;
    this.filteredMedicines = this.listFilter ? this.performFilter(this.listFilter) : this.medicines;
  }

  performFilter(listFilter: string): Medicines[] {
    listFilter = listFilter.toLocaleLowerCase();
    return this.medicines.filter((medicine: Medicines) =>
    medicine.fullNameOfMedicine.toLocaleLowerCase().indexOf(listFilter) !== -1);
 }

  filteredMedicines: Medicines[] = [];

  public medicines: any;
  constructor(private service:MedicinesService) { }

  ngOnInit(): void {
    this.service.getAllMedicines().subscribe({
      next: data =>{
      this.medicines=data;
      this.filteredMedicines=this.medicines;
//console.log(this.filteredMedicines);
    },
    error: err=>this.errorMessage=err
  });
  }
  quantityCheck(q:number)
  {
    if(q<10)
    {
      return 'yellow';
    }
  }

  dateCheck(d:Date)
  {
    var todaysDate = new Date();
console.log(todaysDate.toDateString());
console.log(new Date(d) );
let compareDate= new Date(d);
    if(compareDate < todaysDate) {
    return 'red';

}
  }
}
