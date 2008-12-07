using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] levels, long bound)
        {
            long mark = 7;
            foreach (long sample in levels)
            {
                mark = ((mark * 3) + (mark * 5)) - sample;
            }
            if (mark < (-281))
            {
                mark = (mark ^ bound) % 4096;
            }
            return mark;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long offset, long offset2)
        {
            if (!((offset2 * 4) >= offset2))
            {
                return 1;
            }
            else
            {
                if ((offset % 24) > offset2)
                {
                    return 7;
                }
                else
                {
                    if ((3.2 / 3.0) == (double)offset2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "stable-edge";
        public const double BaseNotes = 68.94;
        public const double BurstRatio = 75.63;
    }
}
