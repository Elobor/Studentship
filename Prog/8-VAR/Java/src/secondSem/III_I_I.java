package secondSem;

import java.util.Scanner;

public class III_I_I {

	public static void main(String[] args) {
		
		int Matr[][] = new int[2][20];
		int P, T;
		Scanner reading = new Scanner(System.in);
		
		for (int str = 0; str < 2; str++) {
			for (int stolb = 0; stolb < 20; stolb++) {
				Matr[str][stolb] = (int) (1+Math.random()*9);
			}
		}
		
		for (int stolb = 0; stolb < 20; stolb++) {
			if (Matr[0][stolb] > (Matr[1][stolb])) {
				int prom=Matr[0][stolb];
				Matr[0][stolb] = Matr[1][stolb];
				Matr[1][stolb] = prom;
			}
			if (Matr[0][stolb] == (Matr[1][stolb])) {
				Matr[1][stolb]++;
			}
		}
		
		System.out.println("Введите Р");
		P = reading.nextInt();
		System.out.println("Введите T");
		T = reading.nextInt();
		
		for (int str = 0; str < 2; str++) {
			for (int stolb = 0; stolb < 20; stolb++) {
				System.out.print(Matr[str][stolb]+" ");
			}
			System.out.println();
		}
		
		for (int stolb = 0; stolb < 20; stolb++) {
			if ((P * T) < ((Math.sqrt(Matr[1][stolb]) * (Math.PI * 4))-Math.sqrt(Matr[0][stolb]) * (Math.PI * 4))) {
				System.out.println("Площадь " + (stolb+1) +" кольца больше площади заданного прямоугольника");
			}
		}
		
		reading.close();
	}

}
