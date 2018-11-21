import java.util.Scanner;

public class SAMER08F {
	private static long square(int number) {
		int result = 0;
		
		for(int i = 0; i<=number; i++) {
			result = result + ((number-i) * (number-i));
		}
		return result;
	}
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in); 

		int n = input.nextInt();
		
		while(n != 0) {
			System.out.println(square(n));
			n = input.nextInt();
		}
		input.close();
	}
}
