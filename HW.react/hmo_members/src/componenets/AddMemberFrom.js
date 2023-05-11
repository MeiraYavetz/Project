import React, { useState } from 'react';
import {useNavigate,useLocation ,NavLink}from 'react-router-dom'
import TextField from '@mui/material/TextField';
// import { DateField, DatePicker } from '@mui/x-date-pickers/DatePicker';
import { addMember as registerFromApi } from "../Services/member.service"
import { addMember } from '../Services/member.service';
import { addVaccine } from '../Services/vaccine.service';
import { LocalizationProvider,DatePicker  } from '@mui/lab';
import DateAdapter from '@mui/lab/AdapterDateFns';


import './HomePage.css';
import { borderRadius } from '@mui/system';



function AddMemberForm(){
const handleSubmitCenter=()=>{
  console.log("i'm here")
  handleSubmit();
  handleClick();
}
  
  async function handleAddMember(member)
  {
    const newMember=await addMember(member);
  }

const handleSubmit = async (event) => {
  event.preventDefault();
  const form = document.querySelector('form');
  const data = new FormData(form);
  const member = {
    fullName: data.get('Name'),
    id: data.get('id'),
    adress: data.get('adress'),
    //BirthDate: data.get('birthDate'),
    telephone: data.get('phone'),
    mobilePhone: data.get('mobilePhone'),
    //DateOfPositiveResult: data.get('DateOfPositiveResult'),
    //DateOfRecovery: data.get('DateOfRecovery')
  };

  try {
    const response = await fetch('http://localhost:7123/api/member', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(member)
    });
     if (!response.ok) {
      throw new Error('Failed to add member');
    }
    console.log('Member added successfully');
  } catch (error) {
    console.error(error);
  }
  handleAddMember(member);
};

async function handleAddVaccine(vaccine)
{
  const newVaccine=await addVaccine(vaccine);
}

const handleClick = async (event) => {
event.preventDefault();
const form = document.querySelector('form');
const data = new FormData(form);
const vaccine = {
  vaccineManuFacturer: data.get('vaccineManufacturer_1'),
  //dateOfVaccine: data.get('dateOfVaccine_1'),
  IdMember: data.get('id'),

};

try {
  const response = await fetch('http://localhost:7123/api/member', {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json'
    },
    body: JSON.stringify(vaccine)
  });
   if (!response.ok) {
    throw new Error('Failed to add member');
  }
  console.log('Member added successfully');
} catch (error) {
  console.error(error);
}
handleAddVaccine(vaccine);
};



const location = useLocation();
  return (
    

    <form >

      <label className='l'>Add member</label> 
      <br></br>
      <TextField
          variant="outlined"
          required
          
          id="Name"
          label="Name"
          name="Name"
          autoComplete="Name"
          autoFocus
          className="TextField"
       
        />   
        <br></br>
        <br></br>

      <TextField
        variant="outlined"
        required
        name="id"
        label="id"
        type="id"
        id="id" 
        className="TextField"
  
        />
        <br></br>
        <br></br>
        
         <TextField
        variant="outlined"
        
        name="adress"
        label="adress"
        type="adress"
        id="adress"
        className="TextField" 
    
        />
        <br></br>
        <br></br>

         <TextField
        variant="outlined"
        
        name="phone"
        label="phone"
        type="phone"
        id="phone" 
        className="TextField"
    
        />
        <br></br>
        <br></br>

         <TextField
        variant="outlined"
        
        name="mobilePhone"
        label="mobilePhone"
        type="mobilePhone"
        id="mobilePhone"
        className="TextField" 

        />
        <br></br>
        <br></br>
        <label>birth date </label>  

<input
        variant="outlined"
        
        name="birthDate"
        label="birthDate"
        type="date"
        id="birthDate" 
        className="DateField"
   
        />
 
        <br></br>
        <br></br>
        <label>date Of Vaccine 1</label>  
        
         <input
        variant="outlined"
        
        name="dateOfVaccine_1"
        label="dateOfVaccine_1"
        type="date"
        id="dateOfVaccine_1" 
        className="DateField"
 
        />
        <TextField
        variant="outlined"
        
        name="vaccineManufacturer_1"
        label="vaccineManufacturer_1"
        type="vaccineManufacturer_1"
        id="vaccineManufacturer_1" 
        className="TextField"
 
        />
        <br></br>
        <br></br>
        <label>date Of Vaccine 2 </label>  

        <input
        variant="outlined"
        
        name="dateOfVaccine_2"
        label="dateOfVaccine_2"
        type="date"
        id="dateOfVaccine_2" 
        className="DateField"
 
        />
         <TextField
        variant="outlined"
        
        name="vaccineManufacturer_2"
        label="vaccineManufacturer_2"
        type="vaccineManufacturer_2"
        id="vaccineManufacturer_2" 
        className="TextField"

        />
        <br></br>
        <br></br>
        <label>date Of Vaccine 3 </label>  

        <input
        variant="outlined"
        
        name="dateOfVaccine_3"
        label="dateOfVaccine_3"
        type="date"
        id="dateOfVaccine_3" 
        className="DateField"
 
        />
        <TextField
        variant="outlined"
        className="TextField"
        
        name="vaccineManufacturer_3"
        label="vaccineManufacturer_3"
        type="vaccineManufacturer_3"
        id="vaccineManufacturer_3" 
   
        />
        <br></br>
        <br></br>
        <label>date Of Vaccine 4 </label>  
        <input
        variant="outlined"
        
        name="dateOfVaccine_4"
        label="dateOfVaccine_4"
        type="date"
        id="dateOfVaccine_4" 
        className="DateField"
 
        />
        <TextField
        variant="outlined"
        
        name="vaccineManufacturer_4"
        label="vaccineManufacturer_4"
        type="vaccineManufacturer_4"
        id="vaccineManufacturer_4" 
        className="TextField"
    
        />
    <br></br>
    <br></br>
    <label>Date Of Positive Result </label>  
    <input
        variant="outlined"
        
        name=""
        label="DateOfPositiveResult"
        type="date"
        id="DateOfPositiveResult" 
        className="DateField"
 
        />
        <br></br>
    <br></br>
    <date
    />

<label>Date Of Recovery </label>  
    <input
        variant="outlined"
        
        name=""
        label="DateOfRecovery"
        type="date"
        id="DateOfRecovery" 
        className="DateField"
 
        />
    <br></br> 
    <br></br>
    <br></br> 
     
      <button type='submit'
      fullWidth
      variant="contained"
      color="primary"
      onClick={handleSubmitCenter}  
      
      >
      Add member</button>
    <br></br>
      
      <br></br>

  
    </form>
  );

}


export default AddMemberForm;