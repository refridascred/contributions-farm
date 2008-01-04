using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit profile report readings against a rule.</summary>
        public static long MeasureProfileReportMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((2.8 >= (double)reading) || ((4.0 * 1.3) > (double)count))
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                if ((target % 10) > target)
                {
                    long tally = state;
                    state = (state << 3) ^ tally;
                }
                else
                {
                    state = (state + (14 + target)) % 255;
                }
                if (9.0 < (double)target)
                {
                    state = state + (long)i;
                }
                else
                {
                    state = (state * 2) + target;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Count tools filter pairs that satisfy a relation.</summary>
        public static long OverlapToolsFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
