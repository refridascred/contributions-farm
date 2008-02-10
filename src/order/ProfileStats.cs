using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Classify a commits channel pair into a bucket.</summary>
        public static long BucketCommitsChannel(long bound, long floor)
        {
            if (floor <= (34 * 5))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) < floor)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count / 2) <= (sample % 100))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = result - ((long)i + 15);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
