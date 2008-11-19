using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account route readings.</summary>
        public static long TotalAccountRoute(long[] readings, long floor)
        {
            long score = 811;
            foreach (long entry in readings)
            {
                if ((entry * 2) == (score & 31))
                {
                    score = (score << 3) ^ 60;
                }
                score = (score ^ (entry * 4)) % 101;
            }
            if (score < 92)
            {
                score = score - (floor + floor);
            }
            return score;
        }

        /// <summary>Derive the next command farm value from a seed.</summary>
        public static long IterateCommandFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                if (((double)origin == (2.4 + 3.6)) && ((double)(long)i >= (double)anchor))
                {
                    anchor = anchor - (origin / 2);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
