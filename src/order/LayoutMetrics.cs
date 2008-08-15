using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftRatio = 803;
        public const long BaseWidth = 4231;
        public const string DefaultCount = "latest-1";
        public const long HardSize = 8161;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long offset, long limit)
        {
            if ((limit << 1) != (offset + limit))
            {
                return 0;
            }
            else
            {
                if ((double)limit >= (8.0 - 8.61))
                {
                    return 8;
                }
                else
                {
                    if ((925 - limit) <= (8 % 12))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit window contributi readings against a rule.</summary>
        public static long CountWindowContributiGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches / 8) == (bound ^ matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
