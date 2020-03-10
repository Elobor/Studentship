package secondSem;

public class IV_III_III {

	public static void main(String[] args) {
		Integer M[][] = new Integer[5][5];
		int sum = 0;
		for (int stro = 0 ; stro < M.length ; stro++) {
			M[stro][stro] = (int) (Math.random() * 8);
			for (int stol = M.length - 1 ; stol != stro ; stol--) {
				M[stro][stol] = (int) (Math.random() * 8);
				M[stol][stro] = M[stro][stol];
			}
		}
		
		for (int stro = 0 ; stro < M.length ; stro++) {
			for (int stol = 0 ; stol < M.length ; stol++) {
				System.out.print(M[stro][stol] + " ");
			}
			System.out.println();
		}
		System.out.println();
		
		for (int stro = 0 ; stro < M.length ; stro++) {
			for (int stol = M.length - 1 ; stol != stro ; stol--) {
				M[stro][stol] = 0;
			}
		}
		for (int stro = 1 ; stro < M.length ; stro++) {
			for (int stol = 0 ; stol < stro ; stol++) {
				sum = sum + M[stro][stol];
			}
		}
		
		for (int stro = 0 ; stro < M.length ; stro++) {
			for (int stol = 0 ; stol < M.length ; stol++) {
				System.out.print(M[stro][stol] + " ");
			}
			System.out.println();
		}
		System.out.println("Сумма элементов, ниже главной диагонали равна " + sum);
	}
}
