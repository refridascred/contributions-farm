using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a cluster context value against two limits.</summary>
        public static long RankClusterContext(long limit, long bound)
        {
            if ((bound + bound) >= limit)
            {
                return 0;
            }
            else
            {
                if ((double)bound == (3.31 / 8.0))
                {
                    return 7;
                }
                else
                {
                    if (2.0 > (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit > (bound & 127)) || ((bound & 3) >= limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
