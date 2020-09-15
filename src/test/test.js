import React, { useState } from 'react';
import './test.css';

const Header = () => {

    /**
     * Isto funciona assim:
     *  é uma função, que pode ter outras funções
     *  no final, tens de ter um return, que é o componente inteiro, que vai ser usado
     *  
     *  como isto vai ter de ter estado e de fazer pedidos, temos de importar o "use state"
     * 
     * ok, mais separado
     * no login, vai ser feito um pedido à db
     * para confirmar se existe o user
     * e temos de comparar os dados de input
     * com os da db
     * (ainda não percebi bem a parte dos pedidos, mas este é o flow)
     * 
     * o design é dentro do return. Temos de colocar o form lá
     * exato
     * mas tem de ir dentro de uma div
     * exato
     * 
     * antes da progrmamção é tipo js
     * fazer pedidos, mexer nos dados. Para depois serem usados
     * 
     * ya
     * 
     * e temos de meter funcionalidade no login , mas é isso que disseste
     * 
     * vou manter este "header" para testes. Vou-lhe mudar só o nome
     * 
     * Este componente, vai ser usado na app
     * ya, isto é só um exemplo para veres o flow
     * */ 


    return (
        
        <div className="exemplo">
            <h1>Aqui tinha um header que ia ser usado algures</h1>
        </div>
    );
}

export default Header;