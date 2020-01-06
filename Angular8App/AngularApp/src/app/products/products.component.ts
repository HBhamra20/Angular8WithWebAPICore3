import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { ProductsService } from '../services/products.service';
import { Products } from '../models/products.model';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  products$: Observable<Products[]>;

  constructor(private productsService: ProductsService) { }

  ngOnInit() {
    this.loadProducts();
  }

  loadProducts() {
    this.products$ = this.productsService.getProducts();
  }

}
