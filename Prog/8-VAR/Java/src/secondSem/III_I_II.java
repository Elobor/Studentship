package secondSem;

import java.util.Scanner;

public class III_I_II {

	public static void main(String[] args) {
	
		Scanner vvod = new Scanner(System.in);
		System.out.println("Введите количество студентов");
		int kolvo = vvod.nextInt();
		
		int Stud[][] = new int[kolvo][4];
		boolean otl = true; 
		float med = 0;
		int otlcount = 0;
		
		for (int nomer = 0; nomer < kolvo; nomer++) {
			for (int ex = 0; ex < 4; ex++) {
				Stud[nomer][ex] = (int) (2 + Math.random()*4);
			}
		}
		
		for (int nomer = 0; nomer < kolvo; nomer++) {
			for (int ex = 0; ex < 4; ex++) {
				System.out.print(Stud[nomer][ex] + " ");
			}
			System.out.println();
		}
		
		for (int nomer = 0; nomer < kolvo; nomer++) {
			med = 0;
			otl = true;
			for (int ex = 0; ex < 4; ex++) {
				if (Stud[nomer][ex] == 2) {
					otl = false;
				}
				med = med + Stud[nomer][ex];
			}
			if (otl) {
				otlcount++;
			}
			System.out.println("Студент номер " + (nomer + 1) + " имеет средний балл = " + med/4);
		}
		
		System.out.println("Количество студентов, не имеющих двоек = " + otlcount);
		
		vvod.close();
	}

}
