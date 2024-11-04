import { MdEmail, MdLock, MdAccountCircle } from 'react-icons/md';
import { useNavigate } from 'react-router-dom';
import { useForm } from "react-hook-form";
import { yupResolver } from '@hookform/resolvers/yup';
import * as yup from "yup";

import { Button } from '../../components/Button';
import { Header } from '../../components/Header';
import { Input } from '../../components/Input';

import { api } from '../../services/api'
import {Column, Container, CriarText, Row, SubtitleCadastro, Title, TitleCadastro, Wrapper} from './styles'

const schema = yup.object({
  name: yup.string().required("Campo obrigatório"),
  email: yup.string().email("E-mail inválido").required("Campo obrigatório"),
  password: yup.string().min(3,"No mínimo 3 caracteres").required("Campo obrigatório"),
}).required();

const Cadastro = () => {
  const navigate = useNavigate();

  const { control, handleSubmit, formState: { errors } } = useForm({
    resolver: yupResolver(schema),
    mode: 'onChange',
  });

  const onSubmit = async formData => {
    try {
      const { data } = await api.post('users', {
        name: formData.name,
        email: formData.email,
        senha: formData.password
      });
      if (data.id) {
        navigate('/feed')
      } else {
        alert("Email ou senha inválido")
      }
    } catch {
      alert("Houve um erro, tente novamente.")
    }
  };

  return (<>
        <Header />
        <Container>
            <Column>
              <Title>
                A plataforma para você aprender com experts, dominar as principais tecnologias
                e entrar mais rápido nas empresas mais desejadas.
              </Title>
            </Column>
            <Column>
              <Wrapper>
                <TitleCadastro>Comece agora grátis</TitleCadastro>
                <SubtitleCadastro>Crie sua conta e make the change._</SubtitleCadastro>
                <form onSubmit={handleSubmit(onSubmit)}>
                <Input name="name" errorMessage={errors?.name?.message} control={control} placeholder="Nome Completo" leftIcon={<MdAccountCircle />}/>
                  <Input name="email" errorMessage={errors?.email?.message} control={control} placeholder="E-mail" leftIcon={<MdEmail />}/>
                  <Input name="password" errorMessage={errors?.password?.message} control={control} placeholder="Senha" type="password" leftIcon={<MdLock />}/>
                  <Button title="Criar minha conta" variant='secondary' type="submit"/>
                </form>
                <Column>
                <br />
                  <SubtitleCadastro>Ao clicar em "criar minha conta grátis", declaro que aceito as Políticas de Privacidade e os Termos de Uso da DIO.</SubtitleCadastro>
                  <Row>
                  <SubtitleCadastro>Já tenho conta.</SubtitleCadastro>
                  <CriarText>Fazer login</CriarText>
                  </Row>
                </Column>
              </Wrapper>
            </Column>
        </Container>
    </>)
}

export { Cadastro }