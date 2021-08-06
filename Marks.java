import java.util.Scanner;

public class Number {
    public static String getInput()
    {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter numbers separated by commas(,): ");
        return sc.nextLine();
    }

    public static boolean isInputValid(String input)
    {
        String[] numbers = input.split(",");
        for (int x=0; x<numbers.length; x++) {
            if (!numbers[x].matches("[0-9]+"))
            {
                System.out.println("Invalid Input! Numbers should be numerical");
                return false;
            }
        }
        return true;
    }

    public static double calcAvgEven(String input)
    {
        String [] list = input.split(",");
        int sum =0, count =0;
        for (int x=0; x< list.length; x++)
        {
            if(Integer.parseInt(list[x])%2 ==0) {
                sum += Integer.parseInt(list[x]);
                count ++;
            }
        }
        return ((double)sum/count);
    }

    public static double calcAvgOdd(String input)
    {
        String[] list = input.split(",");
        int sum=0, count=0;
        for (int y=0; y<list.length; y++)
        {
            if(Integer.parseInt(list[y])%2 != 0)
            {
                sum += Integer.parseInt(list[y]);
                count++;
            }
        }
        return ((double)sum/count);
    }

    public static int findSmall(String input)
    {
        String [] score = input.split(",");
        int small = Integer.parseInt(score[0]);
        for(int i=1; i< score.length; i++)
        {
            if(Integer.parseInt(score[i]) < small)
                small = Integer.parseInt(score[i]);
        }
        return small;
    }

    public static int findHighest(String input)
    {
        String[] score = input.split(",");
        int highest = Integer.parseInt(score[0]);
        for(int i=1; i< score.length; i++)
        {
            if(Integer.parseInt(score[i]) > highest)
                highest =Integer.parseInt(score[i]);
        }
        return highest;
    }
    
    public static void main(String[] args)
    {
        String num;
        do {
            num = getInput();
        } while(!isInputValid(num));
        System.out.println("The average even mark: " +calcAvgEven(num));
        System.out.println("The average odd mark: " +calcAvgOdd(num));
        System.out.println("The smallest mark: " +findSmall(num));
        System.out.println("The highest mark: "+ findHighest(num));
    }
}
