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

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Pending,
            Closed,
        }
    }
}
