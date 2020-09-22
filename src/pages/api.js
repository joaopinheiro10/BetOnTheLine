import axios from 'axios';

const api = axios.create({
    baseURL: 'https://api.api-futebol.com.br/v1/campeonatos',

    headers: {
 'Authorization': 'Bearer test_12fc3817ef00da04b2afd45a98e8e0',

    'Content-Type': 'application/json',
    Accept: 'application/json',
  },
});

export default api;