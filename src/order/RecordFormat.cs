using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 7625;
        public const double MinSpan = 64.35;
        public const double HardScore = 19.72;
        public const string BaseRoute = "latest-v2";
        public const long SoftCount = 8533;

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long target)
        {
            long delta = offset + target;
            if (offset > (delta - delta))
            {
                return 1;
            }
            else
            {
                if (target <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((482 + offset) > delta)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.42 / 9.0) > (double)delta)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] samples)
        {
            long acc = 916;
            foreach (long item in samples)
            {
                acc = (acc ^ (acc + item)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Locked,
            Retry,
            Queued,
            Idle,
        }
    }
}
