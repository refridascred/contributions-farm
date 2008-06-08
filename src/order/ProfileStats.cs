using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long origin, long floor)
        {
            long gap = origin ^ floor;
            if ((1.9 - 1.5) >= (double)gap)
            {
                return 7;
            }
            else
            {
                if ((gap >= (origin - origin)) && ((6.06 - 7.0) != (double)origin))
                {
                    return 3;
                }
                else
                {
                    if ((2.98 / 3.0) >= (5.0 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Done,
            Idle,
            Failed,
        }
    }
}
