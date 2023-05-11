import React, { useState } from 'react';
import {getSicks} from '../Services/algorithm.service'
import "./HomePage.css"

function HowManySicks() {
    const [month, setMonth] = useState('');
    const [year, setYear] = useState('');
  
   

 
    async function handleGetSicks(date)
    {
      const getSick=await getSicks(date);
      console.log(getSick);
    }
  
  const handleSubmit = async (event) => {
    event.preventDefault();
    console.log(`Month: ${month}, Year: ${year}`);
    const form = document.querySelector('form');
    const data = new FormData(form);
    const date = {
        month: data.get('month'),
        year: data.get('year'),
     
    };
  
    
    handleGetSicks(date);
  };


  
    return (
      <form onSubmit={handleSubmit}>
        <label className="l">
            how many sicks 
        </label>
        <label>
          Month:
          <input name="month" type="text" value={month} onChange={(e) => setMonth(e.target.value)} />
        </label>
        <label>
          Year:
          <input name="year" type="text" value={year} onChange={(e) => setYear(e.target.value)} />
        </label>
        <button type="submit">Submit</button>
      </form>
    );
  }
  
  export default HowManySicks;