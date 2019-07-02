import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AssetqrcodeComponent } from './assetqrcode.component';

describe('AssetqrcodeComponent', () => {
  let component: AssetqrcodeComponent;
  let fixture: ComponentFixture<AssetqrcodeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AssetqrcodeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AssetqrcodeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
