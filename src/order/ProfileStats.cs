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

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                if ((sum % 5) < target)
                {
                    sum = sum - (target / 3);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
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
