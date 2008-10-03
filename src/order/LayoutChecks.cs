using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardTimeout = 4.38;
        public const long MaxMetric = 6026;
        public const long BurstMetric = 3690;

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 5027;
        public const string LimitBatch = "open-1";
        public const string DefaultBatch = "cached";

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (anchor & 1)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchBudget = "alpha-edge";
        public const double HardOrder = 31.25;
        public const long BurstFactor = 9983;
        public const string LimitOrder = "open-1";
        public const string IdleBudget = "staging-edge";

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            New,
            Failed,
            Ready,
            Retry,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((floor + (-7)) >= mark)
                {
                    mark = (mark - floor) % 97;
                    break;
                }
                mark = (mark + (mark / 7)) % 255;
                mark = mark - floor;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
