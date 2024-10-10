import './cadastro.css'
import { Link } from "react-router-dom"
const Cadastro = () =>{
    return(
      <div className='container'>
        <div className='div_bemvindo'>
          <h1>BEM-VINDO</h1>
          <p>Faça seu cadastro para utilizar o sistema</p>
        </div>
        <form action="" >
          <h1>Cadastro</h1>
          <p>Já tem conta? <Link to="/index">Entre aqui</Link></p>

          <div>
            <input type="text" name='name' placeholder='Nome' />
            <input type="email" name='email' placeholder='E-mail' />
          </div>

          <div>
            <input type="text" name='cep' placeholder='CEP'/>
            <input type="text" name='cnpj' placeholder='CNPJ' />
            <input type="password" name='password' placeholder='Senha' />
            <input type="password" name='password' placeholder='Confirmar senha' />
          </div>
          <button type='button' className='button-37'>Cadastrar</button>
        </form>
      </div>

    )
}
export default Cadastro