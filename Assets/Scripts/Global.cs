public class Global
{
	public const int ROW=0;
	public const int COLUMN=1;
	public const int LEFTRIGHT = 2;
	public const int RIGHTLEFT = 3;

	public static int minStep = 0;
	public static int level = 0;
	public static bool[,,] map=new bool[5,4,12];
	public static void clear(){
		for (int i = 0; i < 5; i++)
			for (int j = 0; j < 4; j++)
				for (int k = 0; k < 12; k++)
					map [i, j, k] = false;
	}

}
