import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule, FormsModule } from '@angular/forms'; // Ñòúïêà 1 - äîáàâÿø ñè ìîäóëèòå òóê, çàùîòî òîâà å ìîäóëà òè, â êîéòî ñå íàìèðàò êîìïîíåíòèòå, â êîèòî ñìÿòàø äà èçïîëçâàø ôîðìè.

import { AppRoutingModule } from './modules/routing/app-routing.module';
import { ListingModule } from './modules/listing.module';

import { AppComponent } from './components/app-component/app.component';
import { FooterComponent } from './components/static-layout/footer/footer.component';
import { HeaderComponent } from './components/static-layout/header/header.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { HomeComponent } from './components/home/home.component';
import { AboutComponent } from './components/about/about.component';
import { RestaurantsListComponent } from './components/restaurants-list/restaurants-list.component';
import { LoginContainerComponent } from './components/login-container/login-container.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';


@NgModule({
    declarations: [
        AppComponent,
        FooterComponent,
        HeaderComponent,
        PageNotFoundComponent,
        HomeComponent,
        AboutComponent,
        RestaurantsListComponent,
        LoginContainerComponent,
        LoginComponent,
        RegisterComponent
    ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        ReactiveFormsModule,
        FormsModule,
        ListingModule
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
