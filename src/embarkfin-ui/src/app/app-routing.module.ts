import { LoginComponent } from './components/authentication/login/login.component';
import { AssetcaptureComponent } from './components/core/assetcapture/assetcapture.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {path: 'assetcapture', component: AssetcaptureComponent},
  {path: 'login', component: LoginComponent},
  {path : '', component : LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
