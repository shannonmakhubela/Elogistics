using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ELogistics
{
    class DataLayer : IDataLayer
    {
        // instatiae context class
        ELogisticsEntities context = new ELogisticsEntities();


        // ADDRESS SECTION 

        //insert address.
        public bool Insert_Address(Address ad)
        {
            //save address.
            context.Addresses.Add(ad);
           
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        //delete address.
        public bool delete_Address(Address Ad)
        {
            // just to delete.
            //context.Addresses.Remove(Ad);
            
            try
            {
                context.Addresses.Remove(Ad);
                context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
        //fetch address
        public Address fetch_Address(int id)
        {
            // fetch address.
            var ad = (from A in context.Addresses where A.Id.Equals(id) select A).FirstOrDefault();

            if ( ad != null)
            {
                // create new address.
                Address new_ad = new Address();

                //assign retrieved data.
                new_ad.ComplexName = ad.ComplexName;
                new_ad.ComplexNumber = ad.ComplexNumber;
                new_ad.Street = ad.Street;
                new_ad.Suburb = ad.Suburb;
                new_ad.City = ad.City;
                new_ad.Country = ad.Country;
                new_ad.PostalCode = ad.PostalCode;
                new_ad.Province = ad.Province;

                // return obj
                return new_ad;

            }
            return null;

        }
        //update address.
       public bool update_address(Address newdata, Address olddata)
        {
            //ASSIGN NEW DATA TO THE OLD ONE.
            olddata.ComplexNumber = newdata.ComplexNumber;
            olddata.ComplexName = newdata.ComplexName;
            olddata.Street = newdata.Street;
            olddata.Suburb = newdata.Suburb;
            olddata.City = newdata.City;
            olddata.Province = newdata.Province;
            olddata.Country = newdata.Country;
            olddata.PostalCode = newdata.PostalCode;



            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }

        }

        // CUSTOMER SECTION

        //add customer
        public bool add_customer(Customer cus)
        {
            context.Customers.Add(cus);
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
        //delete customer.
        public bool delete_cutomer(Customer customer)
        {
            // just to delete.
            context.Customers.Remove(customer);
            try
            {
                context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return  false;
            }

        }

        //fetch customer.
        public Customer fetch_customer(string email)
        {
            var customer = (from C in context.Customers where C.Email.Equals(email) select C).FirstOrDefault();

            if (customer != null )
            {
                return customer;
            }
            else
            {
                return null;
            }
        }
        //update customer
        public bool update_customer(Customer oldc, Customer newc)
        {
            // assign new one to old one
            oldc.FullName = newc.FullName;
            oldc.Email = newc.Email;
            oldc.ContactNumber = newc.ContactNumber;
            oldc.AddressId = newc.AddressId;

            try
            {
                context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
            
        }

        // DRIVER SECTION.

            // add driver
        public bool add_driver(Driver driver)
        {
            context.Drivers.Add(driver);
            try
            {
                context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
            // remove drive
        public bool delete_driver(Driver driver)
        {
            context.Drivers.Remove(driver);
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
           // fetch driver.
        public Driver fetch_driver(int ID)
        {
            var driver = (from D in context.Drivers where D.Id.Equals(ID) select D).FirstOrDefault();

            //check.
            if (driver != null )
            {
                return driver;
            }
            else
            {
                return null;
            }
        }
           // update driver.
        public bool update_driver(Driver olddriver, Driver newdriver)
        {
            olddriver.FullName = newdriver.FullName;
            olddriver.LicenseType = newdriver.LicenseType;
            olddriver.Owner = newdriver.Owner;

            try
            {
                context.SaveChanges();
                return true;

            }catch(Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }


        // FRIEGHT SECTION.

        // add freight.
        public bool Add_frieght(Freight fr)
        {
            context.Freights.Add(fr);
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
        //delete freight.
        public bool Delete_frieght(Freight fr)
        {
            context.Freights.Remove(fr);
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
        //fetch freight
        public Freight Fetch_frieght(int ID)
        {
            var driver = (from F in context.Freights where F.Id.Equals(ID) select F).FirstOrDefault();

            //check.
            if (driver != null)
            {
                return driver;
            }
            else
            {
                return null;
            }
        }
        //update frieght.
        public bool Update_frieght(Freight oldfr, Freight newfr)
        {
            // incoming update
            oldfr.CustomerId = newfr.CustomerId;
            oldfr.Height = newfr.Height;
            oldfr.Weight = newfr.Weight;
            oldfr.Lenght = newfr.Lenght;
            oldfr.DestinationAddressId = newfr.DestinationAddressId;
            oldfr.OriginAddressId = newfr.OriginAddressId;
            oldfr.StatusId = newfr.StatusId;
            oldfr.Date = newfr.Date;

            //save changes.
            try
            {
                context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        // STATUS SECTION:

        // Add status.
        public bool Add_status(Status st)
        {
            context.Status.Add(st);
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
        // Delete status.
        public bool Delete_status(Status st)
        {
            context.Status.Remove(st);
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
        // fetch status.
        public Status Fetch_status(int ID)
        {
            var st = (from S in context.Status where S.Id.Equals(ID) select S).FirstOrDefault();

            //check.
            if (st != null)
            {
                return st;
            }
            else
            {
                return null;
            }
        }
        // update status.
        public bool Update_status(Status oldst, Status newst)
        {
            //incoming update.
            oldst.Status1 = oldst.Status1;
            oldst.DateDelivered = oldst.DateDelivered;
            oldst.DatePickedUp = oldst.DatePickedUp;
            oldst.DriverId = oldst.DriverId;
            //save changes.
            try
            {
                context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        // AD - ONS.
        public bool CheckCustomer(int ID)
        {
            var st = (from S in context.Customers where S.Id.Equals(ID) select S).FirstOrDefault();

            //check.
            if (st != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckSstatus(int ID)
        {
            var st = (from S in context.Status where S.Id.Equals(ID) select S).FirstOrDefault();

            //check.
            if (st != null)
            {
                return true ;
            }
            else
            {
                return false ;
            }
        }
        public bool CheckDriver(int ID)
        {
            var st = (from S in context.Drivers where S.Id.Equals(ID) select S).FirstOrDefault();

            //check.
            if (st != null)
            {
                return true;
            }
            else
            {
                return false ;
            }
        }

        //lists
        public List<Customer> All_Customers()
        {
            var c_list = new List<Customer>();

            var customers = (from C in context.Customers select C);

            if (customers != null )
            {
                foreach ( var item in customers)
                {
                    c_list.Add(item);

                }
                return c_list;

            }
            else
            {
                return null;
            }
           
        }
        public List<Address> All_Adress()
        {
            var c_list = new List<Address>();

            var ad = (from C in context.Addresses select C);

            if (ad != null)
            {
                foreach (var item in ad)
                {
                    c_list.Add(item);

                }
                return c_list;

            }
            else
            {
                return null;
            }
        }
        public List<Freight> All_Freights()
        {
            var c_list = new List<Freight>();

            var ad = (from C in context.Freights select C);

            if (ad != null)
            {
                foreach (var item in ad)
                {
                    c_list.Add(item);

                }
                return c_list;

            }
            else
            {
                return null;
            }
        }
        public List<Driver> All_Drivers()
        {
            var c_list = new List<Driver>();

            var ad = (from C in context.Drivers select C);

            if (ad != null)
            {
                foreach (var item in ad)
                {
                    c_list.Add(item);

                }
                return c_list;

            }
            else
            {
                return null;
            }
        }
        public List<Status> All_Statuses()
        {
            var c_list = new List<Status>();

            var ad = (from C in context.Status select C);

            if (ad != null)
            {
                foreach (var item in ad)
                {
                    c_list.Add(item);

                }
                return c_list;

            }
            else
            {
                return null;
            }
        }
    }
}
