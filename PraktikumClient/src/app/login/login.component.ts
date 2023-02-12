import { Component } from '@angular/core';
import User from 'src/models/User';
import Child from 'src/models/Child';
import { UserService } from '../services/user.service';
import { ChildService } from '../services/child.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  user: User = new User(0, "", "", null, null, "", "");
  child: Child = new Child(0, "", "", null, null, 0,null);
  isDisplay: boolean = false;
  isExistParent: boolean = false;
  gender: string[] = ["זכר", "נקבה"];
  HMO: string[] = ["מכבי", "מאוחדת", "כללית", "לאומית"];

  constructor(public userSer: UserService, public childSer: ChildService) { }

  addChild(Form) {
    this.child.ParentId = JSON.parse(localStorage.getItem("user")).userId;
    this.child.Parent=JSON.parse(localStorage.getItem("user"));
    this.childSer.login(this.child).subscribe((succ) => {
      localStorage.setItem("child", JSON.stringify(this.child));
      alert("The child has been successfully added")
    }, (err) => {
      localStorage.setItem("child", JSON.stringify(this.child))
      alert("An error occurred child")
    })
    this.child = new Child(0, "", "", null, null, 0);
  }

  display() {
    this.isDisplay = true
  }

  saveUser(Form) {
    this.userSer.login(this.user).subscribe((succ) => {
      localStorage.setItem("user", JSON.stringify(this.user));
      localStorage.setItem("user", JSON.stringify(succ));

      this.isExistParent = true;
      alert("The name has been successfully added")
    }, (err) => {
      localStorage.setItem("user", JSON.stringify(this.user))
      alert("An error occurred user")
    })
  };

  ngOnInit(): void {
    if (localStorage.getItem("user") != null) {
      this.user = JSON.parse(localStorage.getItem("user"));
    }
    else {
      this.user = new User(0, "", "", null, null, "", "");
    }
    if (localStorage.getItem("child") != null) {
      this.child = JSON.parse(localStorage.getItem("child"));
        // this.isExistParent = true
        // this.isDisplay = true
    }
    else {
      this.child = new Child(0, "", "", null, null, 0);
    }
  }

  ngOnDestroy(): void {

    localStorage.setItem("user", JSON.stringify(this.user));
    localStorage.setItem("child", JSON.stringify(this.child));
   
  }
}
