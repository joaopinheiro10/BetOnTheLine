import React, { useState } from "react";
import "./homepage.css";


const Homepage = () => {
  return (

    <div className="Homepage">
      <img id="background" src="/images/background.jpg"></img>
      <img id="logo" src="/images/betontheline.png"></img>

      <form>
        <h3>Login</h3>
        <input type="text" name="email" placeholder="E-mail" />
        <input type="password" name="password" placeholder="Password" />
        <input type="submit" name="action" value="Send" />
      </form>
    </div>
  );
};
export default Homepage;
