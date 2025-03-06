#include <iostream>
using namespace std;

int main() {
    cout << "Your Name - Roll Number" << endl;
    return 0;
}
#include <iostream>
using namespace std;

int main() {
    int a, b;
    cout << "Enter two numbers: ";
    cin >> a >> b;
    if (b != 0) {
        cout << "Quotient: " << a / b << endl;
    } else {
        cout << "Error! Division by zero." << endl;
    }
    return 0;
}
