import React from 'react';
import "./HomePage.css"
import TextField from '@mui/material/TextField';
import { Grid, Link } from '@mui/material';
import {NavLink} from 'react-router-dom';
import { useNavigate } from 'react-router-dom';
import { useLocation } from 'react-router-dom';


//import { BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom';
function HomePage(){
    const navigate = useNavigate();
    const handleClick = (event) => {
      event.preventDefault();
      navigate('/AddMemberForm');
    }
   const handleClick2=(event)=>{
    event.preventDefault();
    navigate('/RetrieveMemberForm')
   }
    return (
      
      <form >
        <label className='l'>Health Fund Home Page</label> 
        
        <br></br>
       
      <br></br>
      <br></br>
      <br></br>      
        <button type='submit'
        fullWidth
        variant="contained"
        color="primary"
        onClick={handleClick}   
        >
        add member</button>
        <button type='submit'
        
        variant="contained"
        color="primary"
        onClick={handleClick2}   
        >
        retrieve member</button>
      <br></br>
      <br></br>
        <br></br>
      
      <br></br>
        <br></br>

        
        
        {/* form fields go here */}
      </form>
    );
  
}
export default HomePage;