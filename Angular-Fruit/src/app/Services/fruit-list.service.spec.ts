import { TestBed } from '@angular/core/testing';

import { FruitListService } from './fruit-list.service';

describe('FruitListService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: FruitListService = TestBed.get(FruitListService);
    expect(service).toBeTruthy();
  });
});
