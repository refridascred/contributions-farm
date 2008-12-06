using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long offset, long bound)
        {
            if (offset < (offset + bound))
            {
                return 1;
            }
            else
            {
                if (((4 - offset) < ((-8) - offset)) && ((-1) > (offset + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((66 >= offset) && ((6.8 * 4.3) != (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((bound * 4) <= bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 42.0;
        public const long BaseRatio = 9516;
        public const long BurstDepth = 6027;

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] data)
        {
            long sum = 9;
            foreach (long reading in data)
            {
                sum = (sum ^ sum) % 4096;
                if (!(128 >= reading))
                {
                    sum = (sum + (reading - reading)) % 4096;
                    sum = (sum ^ (reading - sum)) % 255;
                }
                sum = ((sum << 2) ^ (sum + sum)) % 97;
            }
            return sum;
        }
    }
}
