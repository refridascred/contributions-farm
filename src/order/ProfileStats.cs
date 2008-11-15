using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if ((double)offset2 > (2.0 + 1.31))
            {
                return 7;
            }
            else
            {
                if (!((slot + slot) == (slot % 100)))
                {
                    return 1;
                }
                else
                {
                    if ((slot & 3) > 8)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two batch report measurements.</summary>
        public static double ProjectBatchReport(double bias, double span)
        {
            double ratio = 8.0 + 1.77;
            return ratio + (span + bias);
        }
    }
}
