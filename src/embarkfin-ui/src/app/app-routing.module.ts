import { LoginComponent } from './components/authentication/login/login.component';
import { AssetcaptureComponent } from './components/core/assetcapture/assetcapture.component';
import { AssetgridComponent } from './components/core/assetgrid/assetgrid.component';

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthGuard } from './authguard';

const routes: Routes = [
  {path: 'assetcapture', component: AssetcaptureComponent, canActivate: [AuthGuard]},
  {path: 'assetgrid', component: AssetgridComponent, canActivate: [AuthGuard]},
  {path: 'login', component: LoginComponent},
  {path : '', component : LoginComponent},
  {path: '**', component: LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
