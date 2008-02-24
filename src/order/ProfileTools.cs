using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWidth = 45.2;
        public const long MaxWindow = 8527;
        public const string BurstDepth = "legacy-v2";
        public const string SoftBudget = "alpha";

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long step, long origin)
        {
            long step2 = step - origin;
            if ((step2 << 2) < origin)
            {
                return 0;
            }
            else
            {
                if ((double)origin != (2.0 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if (step < (origin + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step2 % 12) == (step + step2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] series, long origin)
        {
            long mark = 2;
            foreach (long reading in series)
            {
                mark = ((mark + (79 + reading)) % 97) - origin;
            }
            return mark;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
