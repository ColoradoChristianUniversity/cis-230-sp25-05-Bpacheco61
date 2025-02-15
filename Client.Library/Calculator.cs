namespace Client.Library;

public class Calculator : ICalculator
{
    public float Add(float a, params float[] b)
    {
        float sum = a;
        foreach (float num in b)
        {
            sum += num;
        }
        if (float.IsNaN(sum) || float.IsInfinity(sum))
        {
            throw new ArgumentOutOfRangeException(nameof(a));
        }
        return sum;
    }

    public float Divide(float a, params float[] b)
    {
        float quotient = a;
        foreach (float num in b)
        {
            quotient /= num;
        }
        if (float.IsNaN(quotient) || float.IsInfinity(quotient))
        {
            throw new ArgumentOutOfRangeException(nameof(a));
        }
        return quotient;
    }

    public float Modulus(float a, float b)
    {
        float remainder = a % b;
        if (float.IsNaN(remainder) || float.IsInfinity(remainder))
        {
            throw new ArgumentOutOfRangeException(nameof(a));
        }
        return remainder;
    }

    public float Multiply(float a, params float[] b)
    {
        float product = a;
        foreach (float num in b)
        {
            product *= num;
        }
        if (float.IsNaN(product) || float.IsInfinity(product))
        {
            throw new ArgumentOutOfRangeException(nameof(a));
        }
        return product;
    }

    public float Power(float a, float b)
    {
        float result = (float)System.Math.Pow(a, b);
        if (float.IsNaN(result) || float.IsInfinity(result))
        {
            throw new ArgumentOutOfRangeException(nameof(a));
        }
        return result;
    }

    public float SquareRoot(float a)
    {
        if (a < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(a));
        }
        float result = (float)System.Math.Sqrt(a);
        if (float.IsNaN(result) || float.IsInfinity(result))
        {
            throw new ArgumentOutOfRangeException(nameof(a));
        }
        return result;
    }

    public float Subtract(float a, params float[] b)
    {
        float difference = a;
        foreach (float num in b)
        {
            difference -= num;
        }
        if (float.IsNaN(difference) || float.IsInfinity(difference))
        {
            throw new ArgumentOutOfRangeException(nameof(a));
        }
        return difference;
    }
}