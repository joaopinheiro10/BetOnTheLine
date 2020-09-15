import React, { useState } from "react";
import "./homepage.css";

const Homepage = () => {
  return (
    <div className="Homepage">
      <form>
        <h3>Login</h3>
        <input type="text" name="email" placeholder="e-mail..." />
        <input type="password" name="password" placeholder="Sua senha..." />
        <input type="submit" name="acao" value="Enviar" />
      </form>
    </div>
  );
};
export default Homepage;
