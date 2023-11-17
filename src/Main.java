import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int Celsius;
        double Fahrenheit;
        double Kelvin;
        double differenceFahrenheitCelsius = 1.8;

        System.out.println("Наша программа переводит температуру в разные системы исчисления");

        System.out.print("Введите значение температуры в Цельсиях: ");
        Celsius = scanner.nextInt();

        Fahrenheit = Celsius * differenceFahrenheitCelsius + 32;
        System.out.println("Ваш результат в Фаренгейтах: "+Fahrenheit+" градуса");

        Kelvin = Celsius + 273;
        System.out.println("Ваш результат в Кельвинах: "+Kelvin+" градуса");


    }
}