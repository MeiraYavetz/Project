using Common.DTOs;
using Microsoft.Extensions.DependencyInjection;
using Repository.Entities;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Service.AlgorithmAndFunctions
{ 
    public class Algorithm: IAlgorithm
    {
        private readonly IService<MemberDTO> _member;
        private readonly IService<VaccineDTO> _vaccine;
        public static List<MemberDTO> listOfMembers=new();
        public static List<VaccineDTO> listOfVaccine =new();
        public Algorithm(IService<MemberDTO> member,IService<VaccineDTO> vaccine)
        {
            _member = member;
            _vaccine = vaccine;
        }

        
        public async Task init()
        {
            listOfMembers = await _member.GetAllAsync();
            listOfVaccine = await _vaccine.GetAllAsync();
        }
        //כמה חולים פעילים היו בחודש האחרון
        public async Task<int[]> howManySicks(DateDTO dateD)
        {
            await init();
            
            int numOfDays = DateTime.DaysInMonth(dateD.year, dateD.month);
            
            int[] numberOfSicks = new int[numOfDays];
           
            for (int i = 1;i <= numOfDays; i++)
            {
                DateTime date= new DateTime(dateD.year, dateD.month, i);
                foreach(MemberDTO member in listOfMembers)
                {
                    if (date > member.DateOfPositiveResult && date < member.DateOfRecovery)
                        numberOfSicks[i]++;
                    
                }
            }
            return numberOfSicks;
        }
        //כמה חברי קופה אינם מחוסנים כלל
        public async Task<int> howManyWithoutVaccine()
        {
            await init();
            int count = 0;
            var vaccine=new VaccineDTO();
            foreach(MemberDTO member in listOfMembers)
            {
                vaccine=listOfVaccine.Find(x => x.IdMember == member.Id);
                if(vaccine==null)
                    count++; 
            }
            return count;
        }
        //check if the id,phone and mobilePhone are valid
        public bool ValidateIsraeliIdNumber(string idNumber)
        {
            if (idNumber.Length != 9 || !Regex.IsMatch(idNumber, @"^\d{9}$"))
            {
                return false;
            }

            int sum = 0;
            for (int i = 0; i < 8; i++)
            {
                int digit = int.Parse(idNumber[i].ToString());
                sum += (i % 2 == 0) ? digit : ((digit * 2 > 9) ? digit * 2 - 9 : digit * 2);
            }

            int checkDigit = (10 - (sum % 10)) % 10;
            return checkDigit == int.Parse(idNumber[8].ToString());
        }
        // Validate a cell phone number
        public static bool ValidateCellPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 10 || !Regex.IsMatch(phoneNumber, @"^\d{10}$"))
            {
                return false;
            }

            return true;
        }

        // Validate a phone number
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 10 && phoneNumber.Length != 7 || !Regex.IsMatch(phoneNumber, @"^\d+$"))
            {
                return false;
            }

            return true;
        }

    }
}
