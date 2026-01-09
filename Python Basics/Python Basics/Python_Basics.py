

def greet(name):
    return f"Hello, {name}!"

def calculate_total(price, quantity):
    return price * quantity

if __name__ == "__main__":
    name = input("Enter your name: ")
    print(greet(name))

    price = float(input("Enter price: "))
    quantity = int(input("Enter quantity: "))

    total = calculate_total(price, quantity)
    print(f"Total amount: R{total:.2f}")
