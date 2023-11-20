/*
import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-land-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './land-list.component.html',
  styleUrls: ['./land-list.component.css']
})
export class LandListComponent {

}
*/
import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Land } from '../classes/Land';
import { LandService } from '../land.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-land-list',
  templateUrl: './land-list.component.html',
  styleUrls: ['./land-list.component.css']
})
export class CategoryListComponent implements OnInit, OnDestroy {
  landen: Land[] = [];
  landen$: Subscription = new Subscription();
  deleteCategorie$: Subscription = new Subscription();

  errorMessage: string = '';

  constructor(private landService: LandService, private router: Router) {
  }

  ngOnInit(): void {
    this.getCategories();
  }

  ngOnDestroy(): void {
    this.landen$.unsubscribe();
    this.deleteCategorie$.unsubscribe();
  }

  add() {
    //Navigate to form in add mode
    this.router.navigate(['admin/land/form'], { state: { mode: 'add' } });
  }

  edit(id: number) {
    //Navigate to form in edit mode
    this.router.navigate(['admin/land/form'], { state: { id: id, mode: 'edit' } });
  }

  delete(id: number) {
    this.deleteCategorie$ = this.landService.deleteCategory(id).subscribe({
      next: (v) => this.getCategories(),
      error: (e) => this.errorMessage = e.message
    });
  }

  getCategories() {
    this.landen$ = this.landService.getCategories().subscribe(result => this.landen = result);
  }

}