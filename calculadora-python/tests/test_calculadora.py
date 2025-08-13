import sys
import os
sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..')))

from calculadora.main import somar, subtrair, multiplicar, dividir

def test_somar():
    assert somar(2, 3) == 5

def test_subtrair():
    assert subtrair(5, 3) == 2

def test_multiplicar():
    assert multiplicar(4, 3) == 12

def test_dividir():
    assert dividir(10, 2) == 5

def test_dividir_zero():
    try:
        dividir(5, 0)
    except ValueError as e:
        assert str(e) == "Divisão por zero não é permitida."
