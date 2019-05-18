import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {
  NbAuthComponent,
  NbLoginComponent,
  NbRegisterComponent,
  NbLogoutComponent,
  NbRequestPasswordComponent,
  NbResetPasswordComponent,
} from '@nebular/auth';
import { AuthGuard } from './auth/auth-guard.service';
import { CaptureComponent } from './components/assets/capture/capture.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';


const routes: Routes = [
  {
    path: 'assets',
    canActivate: [AuthGuard], // here we tell Angular to check the access with our AuthGuard
    // loadChildren: 'app/pages/pages.module#PagesModule'
    children: [
    {
        path: '',
        component: CaptureComponent,
    }]
  },
  {
    path: 'auth',
    // loadChildren: './auth/auth.module#NgxAuthModule',
    component: NbAuthComponent,
    children: [
      {
        path: '',
        component: NbLoginComponent,
      },
      {
        path: 'login',
        component: NbLoginComponent,
      },
      {
        path: 'register',
        component: NbRegisterComponent,
      },
      {
        path: 'logout',
        component: NbLogoutComponent,
      },
      {
        path: 'request-password',
        component: NbRequestPasswordComponent,
      },
      {
        path: 'reset-password',
        component: NbResetPasswordComponent,
      },
    ],
  },
  { path: '',
    redirectTo: '/assets',
    pathMatch: 'full'
  },
  {
    path: '**',
    component: PageNotFoundComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
