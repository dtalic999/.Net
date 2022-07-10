import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AccountService } from './account/account.service';
import { BasketService } from './basket/basket.service';
import { IPagination } from './shared/Models/pagination';
import { IProduct } from './shared/Models/product';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  
  title = 'Skinet';
  
  constructor(private basketService: BasketService,private accountService:AccountService){}
  ngOnInit(): void {  
    this.loadbasket();
    this.loadCurrentUser();
  }  

  loadCurrentUser()
  {
    const token= localStorage.getItem('token');

    this.accountService.loadCurrentUser(token).subscribe(()=>
    {
      console.log('loaded user');
    },error=>
    {
      console.log(error);
    });
  }

  loadbasket()
  {
    const basketId=localStorage.getItem('basket_id');
    if(basketId)
    {
      this.basketService.getBasket(basketId).subscribe(() =>
      {
        console.log('initialised basket');
      }, error =>
      {
        console.log(error);
      });
    }
  }
  
}
