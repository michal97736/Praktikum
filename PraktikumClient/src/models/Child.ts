import User from "./User";

export default class Child{
    constructor(
        public ChildId: number,
        public FirstName: string,
        public LastName: string,
        public TZ: number,
        public BirthDate: Date,
        public ParentId:number,
        public Parent:User=new User(0, "", "", null, null, "", "")
    ){}
}





