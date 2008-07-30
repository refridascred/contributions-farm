using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((cell << 2) < (bound / 9)) && ((tally >= (cell + 0)) || (tally >= (1 + (-7)))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a command context value against two limits.</summary>
        public static long BucketCommandContext(long step, long bound)
        {
            long slot = step - bound;
            if ((step >= (slot + 1)) && (7.0 < (double)bound))
            {
                return 1;
            }
            else
            {
                if ((step + slot) >= step)
                {
                    return 2;
                }
                else
                {
                    if (step >= (slot % 100))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound > (6.57 - 7.5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 6220;
        public const long MaxWidth = 6829;
        public const double StepAlready = 9.65;
        public const double DefaultAlready = 76.95;
    }
}
