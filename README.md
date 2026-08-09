# Desafio em Squad – Sistema de cadastro de alunos

Squad Carmen Portinho

## Objetivo

Sua squad deverá desenvolver um sistema em C# que permita cadastrar e consultar
informações de alunos utilizando apenas os conceitos estudados até o momento.
Durante o desenvolvimento, pratiquem a divisão de tarefas, integração do código e boas
práticas de programação.

## Conteúdos utilizados

- Variáveis
- Tipos de dados
- Operadores
- Estruturas condicionais
- Estruturas de repetição
- Arrays
- Boas práticas
- Depuração

## Regras

O sistema deverá permitir cadastrar até 10 alunos.

Para cada aluno deverão ser armazenados:

- Nome
- Idade
- Nota 1
- Nota 2

Essas informações deverão ser armazenadas em arrays.

Após os cadastros, o sistema deverá apresentar um menu com as seguintes opções:

```
1 - Listar alunos
2 - Buscar aluno
3 - Exibir aprovados
4 - Exibir média da turma
0 - Encerrar
```

## Divisão da Squad

### Integrante 1 — Cadastro

Responsável por:
- Criar os arrays.
- Receber os dados dos alunos.
- Armazenar as informações.

### Integrante 2 — Listagem

Responsável por mostrar todos os alunos cadastrados.

### Integrante 3 — Busca

Permitir pesquisar um aluno pelo nome.

### Integrante 4 — Aprovação

Mostrar apenas os alunos cuja média seja maior ou igual a 7.
Também informar quantos alunos foram aprovados.

### Integrante 5 — Menu

Criar o menu principal utilizando uma estrutura de repetição para que o programa continue
funcionando até o usuário escolher sair.