import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MedicinesListComponent } from './medicines-list/medicines-list.component';
import { MedicinesDetailComponent } from './medicines-detail/medicines-detail.component';
import { RouterModule } from '@angular/router';

import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [MedicinesListComponent, MedicinesDetailComponent],
  imports: [
    RouterModule.forChild([
      { path: 'medicines', component: MedicinesListComponent },
      {
        path: 'medicines/:id',
        component: MedicinesDetailComponent
      }
    ]),
    CommonModule,
    FormsModule
  ]
})
export class MedicinesModule { }
