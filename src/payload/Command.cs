using System;

namespace Common.Utilities
{
    /// <summary>Command helpers.</summary>
    public static class Command
    {
        /// <summary>Check whether a editor session size is a power of two.</summary>
        public static bool IsEditorSessionPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Interpolate between two cursor values.</summary>
        public static double LerpCursor(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Express a digest count as a percentage.</summary>
        public static double DigestPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Sum the squares of order samples.</summary>
        public static double OrderEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }
    }
}
