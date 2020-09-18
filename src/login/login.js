import React from "react";
import "./login.css";

class Login extends React.Component {
  static displayName = 'Login'
  state = {
    email: '',
    password: '',
    isChecked: false,
    users: [],
  }
  componentDidMount() {
    if (sessionStorage.checkbox && sessionStorage.email !== "") {
      this.setState({
        isChecked: true,
        email: sessionStorage.username,
        password: sessionStorage.password
      })
    }
  }

  onChangeValue = event => {
    this.setState({
      [event.target.name]: event.target.value
    })
  }

  onChangeCheckbox = event => {
    this.setState({
      isChecked: event.target.checked
    })
  }

  loginSubmit = () => {
    const { email, password, isChecked } = this.state
    if (isChecked && email !== "") {
      sessionStorage.username = email
      sessionStorage.password = password
      sessionStorage.checkbox = isChecked
    };
  
    
      fetch("https://my-json-server.typicode.com/joaopinheiro10/fakeAPI/profile")
        .then(res => res.json())
        .then((result) => 
            this.setState({
              ...this.state,
              users: result.items
            }) )
    }
  


  render() {
    const { email, password, isChecked } = this.state



    return (

      <div className="Login">
        <img id="background" src="/images/background.jpg"></img>
        <img id="logo" src="/images/betontheline.png"></img>

        <form>
          <h3>Login</h3>
          <input type="text" name="email" placeholder="E-mail" value={email} onChange={this.onChangeValue} />
          <input type="password" name="password" placeholder="Password" value={password} onChange={this.onChangeValue} />
          <input type="checkbox" checked={isChecked} name="lsRememberMe" onChange={this.onChangeCheckbox} /> <label>Remember me</label>
          <input type="submit" name="action" value="Login" onClick={this.loginSubmit} />
        </form>
      </div>
    )
  }
}

export default Login
