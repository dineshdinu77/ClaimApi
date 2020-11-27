using ClaimService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimService.Repository
{
    public class ClaimRepo : IClaimRepo
    {
        

        private List<Claim> claims;

       

        public ClaimRepo()
        {
            claims = new List<Claim>
            {
                 new Claim{Id = 1, Name="Dinesh", Policy="a12",Claim_amount=10000,Hospital_name="aditya",ContactNo="7032704028"},
                new Claim{Id = 2, Name="rohith", Policy="a123",Claim_amount=15000,Hospital_name="aditya",ContactNo="7032704029"},
                new Claim{Id = 3, Name="sujana", Policy="a124",Claim_amount=15400,Hospital_name="surya",ContactNo="7032704018"},
                new Claim{Id = 4, Name="sandeep", Policy="a125",Claim_amount=500000,Hospital_name="vijay",ContactNo="9032704028"},
                new Claim{Id = 5, Name="sandy", Policy="a325",Claim_amount=505000,Hospital_name="vijayDurga",ContactNo="9232704028"},
            };
        }
        

        public IEnumerable<Claim> GetAll()
        {

     

            var claimlist = claims.ToList();
            return claimlist;

        }
        public Claim ClaimUpload(Claim claim)
        {
            if(claim ==null)
            {
                return null;
            }

            claims.Add(claim);
            return claim;
        }



    }
}
