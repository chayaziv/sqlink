

export class TicketPostType {
    constructor(
        public ticketId: string | null,
        public fullname:string,
        public email: string,
        public description: string,
        public imageUrl: string
    ) {}
  }
