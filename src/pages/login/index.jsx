
import './style.css'
import Pc from '../../assets/pc_img_login.png'
function Login() {

  return (
    
      <div className='container'>
        <div>
          <h1>Bem-vindo</h1>
          <p>Faça seu login</p>
          <img src={Pc} alt="" />
        </div>
        <form action="">
          <p>Ainda não tem login?<a href="">Cadastro</a></p>
          <h1>Login</h1>
          <input type="text" name='name'/>
          <input type="password" name='password'/>
          <button type='button'>Cadastrar</button>
        </form>
      </div>
      
  )
}

export default Login
