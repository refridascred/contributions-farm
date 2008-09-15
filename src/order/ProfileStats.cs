using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((2.29 - 5.66) < (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long offset, long step)
        {
            if ((offset + step) > 3)
            {
                return 8;
            }
            else
            {
                if ((0.6 < (double)step) && ((offset + step) < offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 4) > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - offset) <= 48)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Pending,
            Active,
        }
    }
}
