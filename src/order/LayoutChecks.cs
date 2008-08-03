using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleLevel = 7621;
        public const string StepRatio = "strict";
        public const double HardSpan = 44.89;

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] series, long step)
        {
            long total = 690;
            foreach (long item in series)
            {
                if (!((total >> 2) <= total))
                {
                    total = (total ^ (step + step)) ^ item;
                }
            }
            if (total > 61)
            {
                total = (total - (total + step)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Failed,
            Locked,
            Active,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "stable-1";
        public const long BatchRecord = 4223;
        public const long BurstCount = 6582;
        public const long IdleRecord = 5210;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long limit)
        {
            long step = origin - limit;
            if (((origin + 7) < origin) && (limit > step))
            {
                return 6;
            }
            else
            {
                if ((origin << 1) > (limit / 9))
                {
                    return 2;
                }
                else
                {
                    if (((-58) <= (origin + step)) && ((3.11 + 1.09) != (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
