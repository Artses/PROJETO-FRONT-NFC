import { BrowserRouter, Routes } from 'react-router-dom'
import './index.css'
import Login from './pages/login'
import Cadastro from './pages/cadastro'
function App(){

    <BrowserRouter>
        <Routes>
            <Route path='/' element={<Login/>}/>
            <Route path='./pages/cadastro' element={<Cadastro/>}/>
            <Route path='*' element={<h1>Not Found</h1>}/>
        </Routes>
    </BrowserRouter>
    
}

export default App