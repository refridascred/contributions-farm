using System;

namespace Common.Utilities
{
    /// <summary>Command helpers.</summary>
    public static class Command
    {
        /// <summary>Interpolate between two already values.</summary>
        public static double LerpAlready(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Wrap a already index into a fixed-size ring.</summary>
        public static int WrapAlreadyIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Average a list of command samples.</summary>
        public static double AverageCommand(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Check whether a batch size is a power of two.</summary>
        public static bool IsBatchPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
