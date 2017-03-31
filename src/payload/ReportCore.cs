using System;

namespace Common.Utilities
{
    /// <summary>Report core helpers.</summary>
    public static class ReportCore
    {
        /// <summary>Find the peak command sample.</summary>
        public static double CommandPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Average a list of payload samples.</summary>
        public static double AveragePayload(double[] values)
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

        /// <summary>Compute the greatest common divisor of two record sizes.</summary>
        public static long RecordGcd(long a, long b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (b != 0)
            {
                long next = a % b;
                a = b;
                b = next;
            }
            return a;
        }
    }
}
