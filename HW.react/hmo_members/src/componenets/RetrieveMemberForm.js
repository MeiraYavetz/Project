import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { getWithoutVaccine } from '../Services/algorithm.service';

import './HomePage.css';

function RetrieveMemberForm() {

  const navigate = useNavigate();

  const handleClick=(event)=>{
    event.preventDefault();
    navigate('/HowManySicks');
  }
  
  async function handleGetWithoutVaccine()
    {
      const getwithout=await getWithoutVaccine();
      console.log(getwithout);
    }
  
  const handleSubmit = async (event) => {
    event.preventDefault();
    
    const form = document.querySelector('form');
    const data = new FormData(form);
    
  
    
    handleGetWithoutVaccine();
  };

  return (
    <form >
      <h2>Retrieve Member Form</h2>
      
      <br></br>
      <br></br>
      <br></br>
      <br></br>
      <button type="submit"
      onClick={handleClick}
      >how many sicks every day in month</button>
      <button 
      onClick={handleSubmit}
      >how many members without vaccine</button>
    </form>
  );
}

export default RetrieveMemberForm;