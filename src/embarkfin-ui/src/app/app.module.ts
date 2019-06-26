import { AuthGuard } from './authguard';
import { AuthenticationService } from './services/authentication.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CustomMaterialModule } from './components/core/material.module';
import { AppRoutingModule } from './app-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { AssetcaptureComponent } from './components/core/assetcapture/assetcapture.component';
import { LoginComponent } from './components/authentication/login/login.component';
import { RegisterComponent } from './components/authentication/register/register.component';
import { HttpClientModule } from '@angular/common/http';
import { SidenavigationComponent } from './components/sidenavigation/sidenavigation.component';
import { HeaderComponent } from './components/header/header.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    AssetcaptureComponent,
    LoginComponent,
    RegisterComponent,
    SidenavigationComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    CustomMaterialModule,
    FormsModule,
    HttpClientModule,
    RouterModule
  ],
  providers: [ AuthenticationService, AuthGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
