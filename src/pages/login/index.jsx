
import './style.css'
import { Link } from "react-router-dom"
import Pc from '../../assets/pc_img_login.png'
function Login() {

  return (
    
      <div className='container'>
        <div className='div_bemvindo'>
          <h1>Bem-vindo</h1>
          <p>Faça seu login para prosseguir</p>
          <img src={Pc} alt="" />
        </div>
        <form action="">
          
            <p>Ainda não tem login?<Link to="/Cadastro">Cadastro</Link></p>
            <h1>Login</h1>
        
            <input type="text" name='name' placeholder='Nome'/>
            <input type="password" name='password' placeholder='Senha'/>
            <button type='button' className='button-37'>Entrar</button>
          
        </form>
      </div>
      
  )
}

export default Login
