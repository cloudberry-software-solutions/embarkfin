import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AssetgridComponent } from './assetgrid.component';

describe('AssetgridComponent', () => {
  let component: AssetgridComponent;
  let fixture: ComponentFixture<AssetgridComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AssetgridComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AssetgridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
