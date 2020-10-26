import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Medicines } from '../medicines';
import { MedicinesService } from '../medicines.service';
@Component({
  selector: 'pm-medicines-detail',
  templateUrl: './medicines-detail.component.html',
  styleUrls: ['./medicines-detail.component.css']
})
export class MedicinesDetailComponent implements OnInit {
  pageTitle = 'Medicine Detail';
  errorMessage = '';
    medicine: Medicines ;
  constructor(private route: ActivatedRoute,
    private router: Router,
    private service:MedicinesService) { }

  ngOnInit(): void {
    const param = this.route.snapshot.paramMap.get('id');
    console.log(param);
    if (param) {

      this.getMed(param);
    }

  }
  getMed(id: string): void {
    this.service.getMedicineById(id).subscribe({
      next: data => this.medicine = data,
      error: err => this.errorMessage = err
    });
  }

  onBack(): void {
    this.router.navigate(['/medicines']);
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
