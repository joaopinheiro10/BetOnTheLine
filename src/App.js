import React, { Component } from 'react';
import './App.css';
import Login from './login/login';
import 'primereact/resources/themes/nova/theme.css';
import 'primereact/resources/primereact.min.css';
import 'primeicons/primeicons.css';

import { Menubar } from 'primereact/menubar';
import { withRouter } from 'react-router-dom';


class App extends Component {
  render() {

    const menuitems = [

      
      {
        label: 'Home',
        icon: 'pi pi-fw pi-home',
        command: () => this.props.history.push('/')
      },
      {
        label: 'Sobre',
        icon: 'pi pi-fw pi-user',
        command: () => this.props.history.push('/Sobre')
      },
      {
        label: 'Contato',
        icon: 'pi pi-fw pi-comment',
        command: () => this.props.history.push('/Contato')
      }
    ];

    return (
      <div className="App">

        
        <Menubar model={menuitems} />

        <div id="main">
          <main>
            <div className="content" id="content">
              {this.props.children}
            </div>
          </main>

        </div>

      </div>
    );
  }
}

export default withRouter(App);
