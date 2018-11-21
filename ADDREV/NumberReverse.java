import java.util.Scanner;

public class NumberReverse {
	private static int reverse(int number) {
		int reversed = 0;
		
		while(number!=0) {
			int digit = number%10;
			reversed =reversed * 10 + digit;
			number = number/10;
		}
		return reversed;
	}
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int howManyLines = Short.parseShort(input.nextLine());
		
		while(howManyLines != 0){
			String in = input.nextLine();
			String[] inputs = in.split(" ");
			int sum = reverse(Integer.parseInt(inputs[0])) + reverse(Integer.parseInt(inputs[1])); 
			System.out.println(reverse(sum));
			howManyLines--;
		}
    
		input.close();

	}
}
