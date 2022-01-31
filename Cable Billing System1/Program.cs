// See https://aka.ms/new-console-template for more information
//Named constants – residential customers
const double RES_BILL_PROC_FEES = 4.50;
const double RES_BASIC_SERV_COST = 20.50;
const double RES_COST_PREM_CHANNEL = 7.50;
//Named constants – business customers
const double BUS_BILL_PROC_FEES = 15.00;
const double BUS_BASIC_SERV_COST = 75.00;
const double BUS_BASIC_CONN_COST = 5.00;
const double BUS_COST_PREM_CHANNEL = 50.00;
{
    //declare variables
    int accountNumber;
    char customerType;
    double amountDue;
    Console.WriteLine("This program computes a cable bill.");
    Console.WriteLine("Enter account number: "); //Step 3
    accountNumber=Convert.ToInt32(Console.ReadLine()); //Step 4
    Console.WriteLine("Enter customer type: R, r ");
    Console.WriteLine("(Residential), B, b (Business): "); //Step 5
    customerType=Convert.ToChar(Console.ReadLine()); //Step 6
    switch (customerType) //Step 7
    {
        case 'r': //Step 7a
        case 'R':
            amountDue = residential(); //Step 7a.i
            Console.WriteLine("Account number = " + accountNumber);
            Console.WriteLine("Amount due = $" + amountDue); //Step 7a.ii
            break;
        case 'b': //Step 7b
        case 'B':
            amountDue = business(); //Step 7b.i
            Console.WriteLine("Account number = "+accountNumber); //Step 7b.ii
            Console.WriteLine("Amount due = $"+amountDue); //Step 7b.ii
            break;
        default:
            Console.WriteLine("Invalid customer type.");
            break;
    }
}
double residential()
{
    int noOfPChannels; //number of premium channels
    double bAmount; //billing amount
    Console.WriteLine("Enter the number of premium "+"channels used: ");
    noOfPChannels=Convert.ToInt32(Console.ReadLine());
    bAmount = RES_BILL_PROC_FEES +
    RES_BASIC_SERV_COST +
    noOfPChannels * RES_COST_PREM_CHANNEL;
    return bAmount;
}
double business()
{
    int noOfBasicServiceConnections;
    int noOfPChannels; //number of premium channels
    double bAmount; //billing amount
    Console.WriteLine("Enter the number of basic "+"service connections: ");
    noOfBasicServiceConnections=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of premium "+"channels used: ");
    noOfPChannels=Convert.ToInt32(Console.ReadLine());
    if (noOfBasicServiceConnections <= 10)
        bAmount = BUS_BILL_PROC_FEES + BUS_BASIC_SERV_COST +
        noOfPChannels * BUS_COST_PREM_CHANNEL;
    else
        bAmount = BUS_BILL_PROC_FEES + BUS_BASIC_SERV_COST +
        (noOfBasicServiceConnections - 10) *
        BUS_BASIC_CONN_COST +
        noOfPChannels * BUS_COST_PREM_CHANNEL;
    return bAmount;
}