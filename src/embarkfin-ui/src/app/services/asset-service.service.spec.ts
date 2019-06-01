import { TestBed } from '@angular/core/testing';

import { AssetServiceService } from './asset-service.service';

describe('AssetServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AssetServiceService = TestBed.get(AssetServiceService);
    expect(service).toBeTruthy();
  });
});
