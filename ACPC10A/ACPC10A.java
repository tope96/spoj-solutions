import java.util.Scanner;

public class ACPC10A {
	private static String whatSeries(int a, int b, int c) {
		int check = b-a;
		
		if((b+check) == c) {
			return "AP " + (c+check);
		}else {
			int r = b/a;
			return "GP " + (c*r); 
		}

	}
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		String line = input.nextLine();
		
		while(!(line.equals("0 0 0"))) {
			String[] numbers = line.split(" ");
			System.out.println(whatSeries(Integer.parseInt(numbers[0]), Integer.parseInt(numbers[1]), Integer.parseInt(numbers[2])));
			
			line = input.nextLine();
		}
		input.close();
	}
	
}
