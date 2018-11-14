import java.util.*;
import java.lang.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

    static boolean czyPierwsze(int n) {
        if (n == 1) return false;
        
        if(n != 1) {
            for(int i = 2; i<n; i++) {
                if(n%i == 0) return false;
            }
        }
        return true;
    }



public static void main(String[] args) {

    List <Integer> lista = new ArrayList<Integer>();

    Scanner in = new Scanner(System.in);
    
    int first = in.nextInt();
    

    for(int i = 0; i<first; i++) {
    	lista.add(in.nextInt());
    }

    for(int i = 0; i<lista.size(); i++) {
    	if(czyPierwsze(lista.get(i))) System.out.println("TAK");
    	else System.out.println("NIE");
    }
}
}
