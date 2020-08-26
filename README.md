# Resultado do DoJo #1: Desafio Tester

Este resultado foi fruto de um trabalho colaborativo e de caráter experimental.

**Por favor, fique a vontade para colaborar este documento!!!**

#### Senseis:

* Emerson Lara
* Tito Neto

#### Nonsei:

* Pedro Gomide


---

## Node JS

#### Participantes: 

* Breno Silva
* Lorena Silva
* Marco Tulio
* Rebeca Gaia
* Victor Radael

### Linter
ESLint é uma ferramenta de análise de código estática para identificar padrões problemáticos encontrados no código JavaScript.
    
#### Instalando [eslint](https://eslint.org/):
```bash
cd {path_do_projeto}
npm install eslint --save-dev
npx eslint --init
```

#### Configurando:
##### {path_do_projeto}/.eslintrc.json
Utilizar este arquivo de configuração;

```JSON
{
    "env": {
        "browser": true,
        "es2020": true
    },
    "extends": [
        "airbnb-base"
    ],
    "parserOptions": {
        "ecmaVersion": 12,
        "sourceType": "module"
    },
    "rules": {
    }
}
```
#### Hello World
```bash
cd {path_do_projeto}
npx eslint main.js
```

### Teste Unitário

Jest é uma estrutura de teste de JavaScript mantida pelo Facebook, Inc. com foco na simplicidade. Trabalha com projetos usando: Babel, TypeScript, Node.js, React, Angular, Vue.js e Svelte. Seu objetivo é funcionar fora da caixa e sem configurações.

#### Instalando [Jest](https://jestjs.io/)

```bash
npm install jest --save-dev 
npm run test
jest --init 
```

#### Hello World

Criar o arquivo main.test.ts

##### {path_do_projeto}/main.test.ts

```JS
const volumeEsfera = require('./main.js');

test('Volume da esfera de raio 1 deve ser ', () => {
    expect(volumeEsfera()).toBe(4.1887902047863905)
})

test('Volume da esfera de raio 1 deve ser', () => {})
```

Exemplo da Função

##### {path_do_projeto}/main.ts


```JS
function volumeEsfera(raio) {
  if (raio > 0) {
    // O volume é a medida que corresponde a quantidade de espaço
    // ocupado por um determinado objeto. Dito isso, o volume da
    // esfera refere-se ao espaço interno dessa figura geométrica,
    // sendo calculado a partir da fórmula Ve = 4. p. r³/3.
    return ((4 * Math.PI * Math.pow(raio, 3)) / 3);
  }
  return 0;
}

console.log(volumeEsfera(3));
module.exports = volumeEsfera;
```

#### Rodando
```bash
cd {path_do_projeto}
npm run test
```

---

## Python

#### Participantes: 

* Cesar Abreu
* Hugo Martins
* Raphael Correa
* Raissa Bergamini
* Sara Ferreira


### Linter
Pylint é um verificador de bugs e qualidade de código fonte para a linguagem de programação Python. Ele segue o estilo recomendado pelo PEP 8, o guia de estilo do Python. É similar ao Pychecker mas inclui as seguintes funcionalidades: Verifica o comprimento de uma linha de código
    
#### Instalando [pylint](https://pypi.org/project/pylint/):
```bash
cd {path_do_projeto}
sudo apt install pylint
```

#### Configurando:
Usar versão padrão da aplicação.

#### Hello World
```bash
cd {path_do_projeto}
pylint main.py
```

### Teste Unitário

O pytest é um framework usado para a criação de testes de uma maneira mais dinâmica e rápida. Seus testes devem ser desenvolvidos em python (todos os arquivos devem ser salvos com a extensão . py), o que faz com que o código fique menor, seja mais legível e fácil de dar manutenção.

#### Instalando [Pytest](https://pytest.org)

```bash
pip install -U pytest
```

#### Hello World

##### {path_do_projeto}/main.py

```PY
def soma(x,y):
    return x+y

def subtracao(x,y):
    return x-y

def produto(x,y):
    return x*y

def divisao(x,y):
    return x/y
```
##### {path_do_projeto}/main.py
```PY
def test_resposta_soma_erro():
    assert soma(1,1) == 3

def test_resposta_soma():
    assert soma(1,1) == 2

def test_resposta_soma_vazio():
    assert soma() == 0

def test_resposta_subtracao_correta():
    assert subtracao(4,5) == -1 

def test_produto_correto():
    assert produto(2,2) == 4

def test_produto_erro():
    assert produto(2,2) == 5

def test_associacao_soma_produto():
    assert produto(soma(1,1),soma(0,2)) == 4

def test_divisao_por_zero():
    with raises(Exception):
        x = divisao(1,0) 
```

#### Rodando
```bash
cd {path_do_projeto}
pytest main.py
```

---

## Dotnet Core

#### Participantes: 

* Kami Sama, Deus, Buda e Odin
* Alessandro Duarte
* Ana Gomes
* Glauco Leme


### Linter
Não foi encontrado ferramenta que utiliza linha de comando, dificultando uma integração com DevOps.

No editor, VSCode, é exibido os erros ao longo do código ou no própria interface (Ctrl+Shift+M), cabendo o próprio desenvolvedor ter o hábito de corrigir.
    

### Teste Unitário

De acordo com a documentação, xUnit é uma ferramenta gratuita e de código aberto construída para o . NET Framework. Serve para auxiliar na construção e execução de testes unitários, ou melhor, trechos de códigos construídos para testar partes específicas de determinado sistema.

#### Instalando [XUnit](https://xunit.net/)

Não tente criar um arquivo de teste dentro do seu projeto atual, a não ser que você tenha muito tempo livre para achar uma solução que não existe no estou com sorte do Google.

Crie outro projeto de teste e inclua as referências ao seu projeto atual.
(Opnião do Glauco, sinta-se livre para me corrigir)

```bash
cd {path_da_solução}
dotnet new xunit -o {nome_do_projeto}.Test
dotnet add {nome_do_projeto}.Test.csproj reference {path_do_projeto}/{nome_do_projeto}.csproj 
```

#### Hello World

##### {path_do_projeto}/{nome_do_projeto}/main.cs

```CS
using System;

namespace dojofinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma simples: 1+1={0}", Soma(1,1));
        }

        public static int Soma(int var1, int var2){
            return var1 + var2;
        }
    }
}
```
##### {path_do_projeto}/{nome_do_projeto}.Test/main.test.cs
```CS
using Xunit;

namespace dojofinal
{
    public class ProgramTest
    {
        [Fact]
        public void PassingTestSoma()
        {
            Assert.Equal(4, Program.Soma(2,2));
        }

        [Fact]
        public void ErrorTestSoma()
        {
            Assert.Equal(4, Program.Soma(2,1));
        }
    }
}
```

#### Rodando
```bash
cd {path_do_projeto}
dotnet test
```
