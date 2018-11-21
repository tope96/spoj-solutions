import java.math.BigInteger;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class FCTRL2 {
	private static String factorial(int number) {
		BigInteger result = new BigInteger("1");
	       for (int i = 1; i <= number; i++) {
	           result = result.multiply(new BigInteger(i + ""));
	       }
	       return result.toString();
	}
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int howManyLines = Short.parseShort(input.nextLine());
		List<String> all = new ArrayList<String>();
		
		while(howManyLines != 0){
			all.add(factorial(input.nextInt()));
			howManyLines--;
		}
		
		for(String i : all) {
			System.out.println(i);
		}
		input.close();
	}
}
