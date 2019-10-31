import java.util.Scanner;

public class QA {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Scanner sc = new Scanner(System.in);
		boolean app = true;
		while(!app)
		{
			System.out.println("Indtast tal nummer 1");
			int tal1 = sc.nextInt();

			System.out.println("Indtast operator (/*-+)");
			string operator = sc.nextInt();

			System.out.println("Indtast tal nummer 2");
			int tal2 = sc.nextInt();
			float result = 0;
			switch (operator) {
				case (*):
				result = tal1 * tal2;
				app = exitter(result,sc);
				break;
				case(/):
				result = tal1 / tal2;
				app = exitter(result,sc);
				break;
				case(-):
				result = tal1 - tal2;
				app = exitter(result,sc);
				break;
				case(++):
				result = tal1 + tal2;
				app = exitter(result,sc);
				break;
				default:
					System.out.println("Der ser sket en fejl");
					break;			
			}
			
		}
		sc.close();
		

	}
	static public boolean exitter(float result, Scanner sc) {
		System.out.println("Resultatet er " + result);

		System.out.println("Tast y for at lukke programmet");
		String close = sc.next();
		if(close == "y"){
			 return false;
		}
		return true;
		
	}

}
