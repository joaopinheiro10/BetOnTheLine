import React, { Component } from 'react';
import './table.css'
import Api from './api';



class Home extends Component {
    state = {
        campeonatos: [],
    }

    async componentDidMount() {
        const response = await Api.get('');

        this.setState({ campeonatos: response.data });
    }

    render() {

        const { campeonatos } = this.state;

        return (
            <div>



                <h1>Listar os Campeonatos</h1>
                {campeonatos.map(campeonato => (
                    <li key={campeonato}>
                        
                        <p>
                            {campeonato.nome}
                        </p>

                        <table class="table table-striped">
                            <tr>
                                <th>ID</th>
                                <th>Campeonato</th>
                                <th>Status</th>
                                <th>Tipo</th>
                            </tr>
                            
                            <tr>
                                    <td>{campeonato.campeonato_id}</td>
                                    <td>{campeonato.nome}</td>
                                    <td>{campeonato.status}</td>
                                    <td>{campeonato.tipo}</td>
                            </tr>

                        </table>

                    </li>




                ))}



            </div>
        );
    }
}
export default Home;