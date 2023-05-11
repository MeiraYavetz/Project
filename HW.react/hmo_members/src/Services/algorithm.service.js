import axios from './axios'

export function getSicks(date) {
    return axios.post('/Algorithm', date)
        .then(response => response.data)
        .catch(error => console.log(error))
}
export function getWithoutVaccine(){
    return axios.get('/Algorithm',)
    .then(response => response.data)
    .catch(error=>console.log(error))
}
