using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double floor)
        {
            double drift = (rate / 4.0) + (9.99 * 17.0);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)(long)i) - floor;
            }
            return drift + (7.4 + rate);
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((27 + tally) <= (tally ^ sample)) || (((limit << 2) < (6 - limit)) || ((tally >> 2) != ((-865) << 1))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
