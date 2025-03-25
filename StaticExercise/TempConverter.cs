namespace StaticExercise;

public static class TempConverter
{
    public static double FahToCel(double fahTemp)
    {
        return (fahTemp - 32) / 1.8;
    }

    public static double CelToFah(double celTemp)
    {
        return (celTemp * 9/5) + 32;
    }
}