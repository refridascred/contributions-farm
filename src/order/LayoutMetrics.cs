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

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "strict-v2";
        public const double BatchReport = 20.38;
        public const double HardBudget = 12.54;

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
