import axios from './axios'


export function getVaccines() {
    return axios.get('/Vaccine',)
        .then(response => response.data)
        .catch(error => { console.log(error) })
}

export function addVaccine(user) {
    return axios.post('/Vaccine', user)
        .then(response => response.data)
        .catch(error => console.log(error))
}

export function getByIdVaccine(id) {
    return axios.get(`/Vaccine/${id}`)
        .then(response => response.data)
        .catch(error => console.log(error))
}