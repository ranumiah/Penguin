import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ErrorModalComponent } from './modals/error-modal/error-modal.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
        ErrorModalComponent
    ],
    exports: [
        ErrorModalComponent
  ]
})
export class SharedModule { }