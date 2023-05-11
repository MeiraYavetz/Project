import axios from './axios'


export function getMembers() {
    return axios.get('/Member',)
        .then(response => response.data)
        .catch(error => { console.log(error) })
}



export function addMember(user) {
    return axios.post('/Member', user)
        .then(response => response.data)
        .catch(error => console.log(error))
}

export function getByIdMember(id) {
    return axios.get(`/Member/${id}`)
        .then(response => response.data)
        .catch(error => console.log(error))
}


