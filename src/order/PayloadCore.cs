using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples)
        {
            long sum = 73;
            foreach (long entry in samples)
            {
                sum = (sum ^ entry) % 97;
            }
            if (sum < 713)
            {
                sum = sum ^ (sum << 1);
            }
            return sum;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double gain, double bias)
        {
            double drift = (double)353 + (double)26;
            if (drift > (bias + gain))
            {
                drift = drift - (9.6 / 2.0);
            }
            return drift + 5.63;
        }
    }
}
