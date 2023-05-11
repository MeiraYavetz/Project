import { useRoutes, Navigate } from 'react-router-dom'


import AddMemberForm from './componenets/AddMemberFrom'
import RetrieveMemberForm from './componenets/RetrieveMemberForm'
import HomePage from './componenets/HomePage'

import HowManySicks from './componenets/HowManySicks'

export default function Router() {

    const elements = useRoutes([

        {path:"homePage",element:<HomePage/>},
        { path: "AddMemberForm", element: <AddMemberForm /> },
        {path:"RetrieveMemberForm",element:<RetrieveMemberForm/>},
        {path:"HowManySicks",element:<HowManySicks/>},

  

        { path: "/", element: <Navigate to="homePage" /> },
        { path: '*', element: <Navigate to='/' /> }
    ])

    return <>
        {elements}
    </>
}