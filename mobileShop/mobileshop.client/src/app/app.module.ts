import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
//import { ForgotPasswordComponent } from './ForgotPasswordPage/forgotpassword.component';
//import { ShopPageComponent } from './shop-page/shop-page.component';
import { HomePageComponent } from './home-page/home-page.component';
import { LoginComponent } from './login-page/login.component';
import { ProductPageComponent } from './product-page/product-page.component';

@NgModule({
  declarations: [
    AppComponent,
    //ForgotPasswordComponent,
    //ShopPageComponent,
    HomePageComponent,
    LoginComponent,
    ProductPageComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
