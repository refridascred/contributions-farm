using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next command support value from a seed.</summary>
        public static long IterateCommandSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                if (step < (step ^ step))
                {
                    result = ((result << 3) ^ (step + step)) % 97;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftSize = 74.71;
        public const long BatchWindow = 8786;
        public const string IdleRatio = "open-1";

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
