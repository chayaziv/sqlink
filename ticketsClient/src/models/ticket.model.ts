
export class TicketType  {
    constructor(

        public id: string | null,
        public fullname:string,
        public email: string,
        public description: string,
        public imageUrl: string,
       public statusId:number,
       public summary :string,
       public solution:string,

    ) {}
  }
