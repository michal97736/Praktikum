import { Component } from '@angular/core';
import User from 'src/models/User';

@Component({
  selector: 'app-directive',
  templateUrl: './directive.component.html',
  styleUrls: ['./directive.component.scss']
})
export class DirectiveComponent {
user:User= new User(0,"","",null,null,"","");

 ngOnInit(): void {
    this.user=JSON.parse(localStorage.getItem("user"))
  }
}
