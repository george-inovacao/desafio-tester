def soma(x,y):
    return x+y

def subtracao(x,y):
    return x-y

def produto(x,y):
    return x*y

def divisao(x,y):
    return x/y

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
