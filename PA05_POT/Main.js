import java.util.*;
import java.lang.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

	static void potegi(long a, long b) {
		long last = a%10;
		
		if(last == 0 || last==1 || last==5 || last==6) System.out.println(last);
		if(last == 4) {
			if(b%2 == 0) System.out.println(6);
			else System.out.println(4);
		}
		if(last == 9) {
			if(b%2 == 0) System.out.println(1);
			else System.out.println(9);
		}
		
		if(last == 2) {
			if(b%4 == 1) System.out.println(2);
			if(b%4 == 2) System.out.println(4);
			if(b%4 == 3) System.out.println(8);
			if(b%4 == 0) System.out.println(6);
		}
		
		if(last == 3) {
			if(b%4 == 1) System.out.println(3);
			if(b%4 == 2) System.out.println(9);
			if(b%4 == 3) System.out.println(7);
			if(b%4 == 0) System.out.println(1);
		}
		
		if(last == 7) {
			if(b%4 == 1) System.out.println(7);
			if(b%4 == 2) System.out.println(9);
			if(b%4 == 3) System.out.println(3);
			if(b%4 == 0) System.out.println(1);
		}
		
		if(last == 8) {
			if(b%4 == 1) System.out.println(8);
			if(b%4 == 2) System.out.println(4);
			if(b%4 == 3) System.out.println(2);
			if(b%4 == 0) System.out.println(6);
		}
	}
	
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		String input = in.nextLine();
		List<String> lista = new ArrayList<String>();
		
		for(int i = 0; i<Integer.parseInt(input); i++) {
	    	lista.add(in.nextLine());
	    }
		
		 for(int i = 0; i<lista.size(); i++) {
		    	String[] p = lista.get(i).split(" ");
		    	potegi(Long.parseLong(p[0]), Long.parseLong(p[1]));
		    }
	}
	
}
