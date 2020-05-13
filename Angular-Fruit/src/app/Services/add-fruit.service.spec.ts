import { TestBed } from '@angular/core/testing';

import { AddFruitService } from './add-fruit.service';

describe('AddFruitService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AddFruitService = TestBed.get(AddFruitService);
    expect(service).toBeTruthy();
  });
});
