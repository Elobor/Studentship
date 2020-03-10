package secondSem;

import java.util.Scanner;
import java.util.stream.Stream;

public class IV_III_II {

	public static void main(String[] args) {
		
		Scanner vvod = new Scanner(System.in);
		System.out.println("Введите количество строк");
		int strok = vvod.nextInt();
		System.out.println("Введите количество столбцов");
		int stolb = vvod.nextInt();
		
		int[][] Mat = new int[strok][stolb];
		
		for (int str = 0; str < strok; str++) {
			for (int sto = 0; sto < stolb; sto++) {
				Mat[str][sto] = (int) (1+Math.random()*9);
			}
		}
		
		for (int str = 0; str < strok; str++) {
			for (int sto = 0; sto < stolb; sto++) {
				System.out.print(Mat[str][sto] + " ");
			}
			System.out.println();
		}
		
		
		
		vvod.close();
		}

	public int[][] isMaxOrMin(int[][] Matri) {
		
		int elements = Stream.of(Matri).mapToInt(m -> m.length).sum();
		
		int MaxMin[][] = new int[2][elements/Matri.length];
		
		for (int i = 0; i < Matri.length; i++) {
			for (int sto = 0; sto < elements/Matri.length; sto++) {
				if (i == 0) {
					MaxMin[0][sto] = Matri[i][sto];
					MaxMin[1][sto] = Matri[i][sto];
				}
				if (Matri[i][sto] > MaxMin[0][sto]) {
					MaxMin[0][sto] = Matri[i][sto];
				}
				if (Matri[i][sto] < MaxMin[1][sto]) {
					MaxMin[1][sto] = Matri[i][sto];
				}
			}
		}		
		return MaxMin;
	}

}
