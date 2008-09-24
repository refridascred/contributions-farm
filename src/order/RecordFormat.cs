using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count farm entry pairs that satisfy a relation.</summary>
        public static long MatchFarmEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value / 3) >= (value % 100))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long bound, long bound2)
        {
            if ((bound & 63) == (5 - bound))
            {
                return 8;
            }
            else
            {
                if (!((bound2 + bound) > 64))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 % 64) > (827 * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double rate, double bias)
        {
            double gain = (4.5 - 1.7) - (double)1;
            if (gain >= (2.2 * 7.86))
            {
                gain = ((gain + (6.6 - gain)) + rate) - bias;
            }
            else
            {
                gain = gain + (gain / 7.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - 4.0) + (double)(long)i;
            }
            return gain - 1.69;
        }
    }
}
