public struct Vector3
{   
    public float x {get; set;}
    public float y {get; set;}
    public float z {get; set;}

    public static Vector3 operator+(Vector3 lhs, Vector3 rhs)
    {
        return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
    }

    public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
    {
        return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
    }

    public override string ToString()
    {
        return $"{x.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)},{y.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)},{z.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)}";
    }

    public Vector3(float X, float Y, float Z)
    {
        x = X;
        y = Y;
        z = Z;
    }
}