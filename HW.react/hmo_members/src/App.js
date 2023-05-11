import logo from './logo.svg';
import './App.css';
import HomePage from './componenets/HomePage'
import { BrowserRouter } from 'react-router-dom'
import Router from './useRouter'
import AddMemberForm from './componenets/AddMemberFrom';

function App() {
  return (
    
      <div className="App">
  {/* <HomePage/> */}
  {/* <AddMemberForm/> */}
        <BrowserRouter>
          <Router/>
        </BrowserRouter>
    </div>
  );
}

export default App;
