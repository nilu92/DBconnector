﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace FormUI
{
  public  class DataAccess
    {
        public List<Person> GetPeople(string LastName) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnVal("Sample")))
            {
                //var output = connection.Query<Person>($"select * from People where LastName ='{LastName}'").ToList();
                //var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = LastName }).ToList();
               return connection.Query<Person>($"select * from People where LastName = '{LastName}'").ToList();
                
            }
        }

        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnVal("Sample"))) 
            {
                /*Person newPerson = new Person 
                {  FirstName = firstName,  LastName = lastName,  EmailAddress = emailAddress,  PhoneNumber = phoneNumber  };
                */
                List<Person> people = new List<Person>();
                people.Add(new Person { FirstName = firstName,LastName = lastName,EmailAddress = emailAddress,PhoneNumber = phoneNumber });

                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
            }
        }
    }
}
