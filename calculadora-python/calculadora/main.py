def somar(a, b):
    return a + b

def subtrair(a, b):
    return a - b

def multiplicar(a, b):
    return a * b

def dividir(a, b):
    if b == 0:
        raise ValueError("Divisão por zero não é permitida.")
    return a / b

def calculadora():
    print("=== Calculadora Profissional ===")
    try:
        num1 = float(input("Digite o primeiro número: "))
        num2 = float(input("Digite o segundo número: "))
        operacao = input("Digite a operação (+, -, *, /): ")

        operacoes = {
            "+": somar,
            "-": subtrair,
            "*": multiplicar,
            "/": dividir
        }

        if operacao not in operacoes:
            print("Operação inválida.")
            return

        resultado = operacoes[operacao](num1, num2)
        print(f"Resultado: {resultado}")

    except ValueError as e:
        print(f"Erro: {e}")

if __name__ == "__main__":
    calculadora()
