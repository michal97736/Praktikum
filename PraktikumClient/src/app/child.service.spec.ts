import { TestBed } from '@angular/core/testing';

import { ChildService } from './services/child.service';

describe('ChildService', () => {
  let service: ChildService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ChildService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
