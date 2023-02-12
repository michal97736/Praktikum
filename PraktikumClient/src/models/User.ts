export default class User {
    constructor(
        public UserId: number,
        public FirstName: string,
        public LastName: string,
        public TZ: number,
        public BirthDate: Date,
        public Gender: string,
        public HMO: string,

    ) { }
}
