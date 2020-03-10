package secondSem;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.Scanner;

public class V_I {

static File myText = new File("C:\\Users\\Izoto\\git\\Studentship\\Prog\\8-VAR\\Java\\src\\secondSem\\Files\\myText.txt");

	public static void main(String[] args) throws Exception {
		myText.mkdir();
		File textMirror = new File ("C:\\Users\\Izoto\\git\\Studentship\\Prog\\8-VAR\\Java\\src\\secondSem\\Files\\myTextUpperCase.txt");
	
		if (textMirror.exists()) {
			textMirror.delete();
		}
	
		if (!textMirror.exists()) {
			textMirror.createNewFile();
		}
		FileWriter writing = new FileWriter(textMirror);
		FileReader readMyText = new FileReader(myText);
		Scanner reading = new Scanner(readMyText);
		
		while (reading.hasNextLine()) {
			writing.write(reading.nextLine().toUpperCase()+"\n");
		}
		
		writing.close();
		reading.close();
	}

}
