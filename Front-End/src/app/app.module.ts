import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { StartComponent } from './start/start.component';
import { MatDialogModule } from '@angular/material/dialog';
import { DialogAskModeComponent } from './dialog-ask-mode/dialog-ask-mode.component';
import {MatButtonModule} from '@angular/material/button';
import {MatButtonToggleModule} from '@angular/material/button-toggle';
// import {JdatePipe} from 'ngx-persian';
// import { PersianPipesModule } from 'ngx-persian-pipe';

@NgModule({
  declarations: [
    AppComponent,
    StartComponent,
    DialogAskModeComponent,
    // PersianPipesModule
    // JdatePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatDialogModule,
    MatButtonModule,
    MatButtonToggleModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
