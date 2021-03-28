using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELogistics
{
    
    interface IDataLayer
    {
        // Address .
        bool Insert_Address(Address ad);
        bool delete_Address(Address ad);
        Address fetch_Address(int id);
        bool update_address(Address ad,Address olddata);

        // CUSTOMER
        bool add_customer(Customer cus);
        bool delete_cutomer(Customer cus);
        Customer fetch_customer(string email);
        bool update_customer(Customer oldc , Customer newc);

        // Driver
        bool add_driver(Driver driver);
        bool delete_driver(Driver driver);
        Driver fetch_driver(int ID);
        bool update_driver(Driver olddriver, Driver newdriver);

        // Frieght 
        bool Add_frieght(Freight fr);
        bool Delete_frieght(Freight fr);
        Freight Fetch_frieght(int ID);
        bool Update_frieght(Freight oldfr, Freight newfr);

        // STATUS
        bool Add_status(Status st);
        bool Delete_status(Status st);
        Status Fetch_status(int ID);
        bool Update_status(Status oldst, Status newst);

        // AD - ONS
        //bool CheckItems<T>(T ID , T query);
        bool CheckCustomer(int ID);
        bool CheckSstatus(int ID);
        bool CheckDriver(int ID);

        // List.
        List<Customer> All_Customers();
        List<Address> All_Adress();
        List<Freight> All_Freights();
        List<Driver> All_Drivers();
        List<Status> All_Statuses();




    }
}
