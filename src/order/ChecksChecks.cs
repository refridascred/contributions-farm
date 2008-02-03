using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long seed, long limit)
        {
            if ((seed * 2) > (9 % 12))
            {
                return 5;
            }
            else
            {
                if (((9.4 / 4.0) <= (double)seed) || ((seed - limit) > (seed & 31)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value << 1) != (value << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
