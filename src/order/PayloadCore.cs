using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
