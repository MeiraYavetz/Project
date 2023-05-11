

import axios from 'axios'

const axiosInstance = axios.create({ baseURL: 'https://localhost:7196/api' })
axiosInstance.interceptors.request.use(req => {
    return req
})

export default axiosInstance



