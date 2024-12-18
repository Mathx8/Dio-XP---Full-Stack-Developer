import React from 'react'
import { useNavigate } from 'react-router-dom';

import logo from '../../assets/logo-dio.png'
import { Button } from '../Button';
import { IHeader } from './types';

import {
    BuscarInputContainer,
    Container,
    Input,
    Menu,
    MenuRight,
    Row,
    UserPicture,
    Wrapper
} from './styles';

const Header = ({autenticado}: IHeader) => {

  const navigate = useNavigate();

  const handleClickSignIn = () => {
    navigate('/login')
  }

  const handleClickRegister = () => {
    navigate('/cadastro')
  }

  return (
    <Wrapper>
        <Container>
            <Row>
                <img src={logo} alt='Logo da DIO' />
                {autenticado ? (
                    <>
                    <BuscarInputContainer>
                        <Input placeholder='Buscar...'/>
                    </BuscarInputContainer>
                    <Menu>Live Code</Menu>
                    <Menu>Global</Menu>
                    </>
                ) : null}
            </Row>
            <Row>
              {autenticado ? (
                <UserPicture src="https://avatars.githubusercontent.com/u/168006920?v=4&size=64"/>
              ) : (
              <>
                <MenuRight href="/">Home</MenuRight>
                <Button title="Entrar" onClick={handleClickSignIn}/>
                <Button title="Cadastrar" onClick={handleClickRegister} />
              </>)}
          </Row>
        </Container>
    </Wrapper>
  )
}

export { Header }