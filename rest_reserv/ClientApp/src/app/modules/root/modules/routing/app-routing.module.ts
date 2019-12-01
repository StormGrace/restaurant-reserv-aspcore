import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from '../../components/home/home.component';
import { RestaurantsListComponent } from '../../components/restaurants-list/restaurants-list.component';
import { AboutComponent } from '../../components/about/about.component';
import { PageNotFoundComponent } from '../../components/page-not-found/page-not-found.component';
import { LoginContainerComponent } from '../../components/login-container/login-container.component';
import { LoginComponent } from '../../components/login/login.component';
import { RegisterComponent } from '../../components/register/register.component';


const routes: Routes = [
    {
       path: '', redirectTo: 'home', pathMatch: 'full'
    },
    {
        path: 'home', component: HomeComponent
    },
    {
        path: 'restaurants', component: RestaurantsListComponent
    },
    {
        path: 'about', component: AboutComponent
    },
    {
        path: 'auth', component: LoginContainerComponent, children: [
            { path: '', redirectTo: 'signin', pathMatch: 'full'},
            { path: 'signin', component: LoginComponent },
            { path: 'signup', component: RegisterComponent },
            { path: '**', component: PageNotFoundComponent }
        ]
    },
    {
        path: '**', component: PageNotFoundComponent
    }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
