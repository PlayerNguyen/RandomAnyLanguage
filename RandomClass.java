import java.util.Random;

public class RandomClass {

	/**
	 * Random Int Class
	 * @param min
	 * @param max
	 * @return
	 */
	public static int RandomInt(int min, int max)
	{
		Random rand = new Random();
		return rand.nextInt(max) + min;
	}
	
	public static float RandomFloat(float min, float max)
	{
		Random rand = new Random();
		return rand.nextFloat() * max + min;
	}
	
	public static Long RandomLong(Long min, Long max)
	{
		Random rand = new Random();
		return rand.nextLong() * max + min;
	}
	
	public static double RandomDouble(double min, double max)
	{
		Random rand = new Random();
		return rand.nextDouble() * max + min;
	}
	
	public static boolean RandomBoolean()
	{
		Random rand = new Random();
		int boolValue = rand.nextInt(2) + 1;
		
		if (boolValue == 1)
		{
			return true;
		}
		else
		{
			return false;
		}
		
	}
	
}
