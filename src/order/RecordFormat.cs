using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a support queue value against two limits.</summary>
        public static long GradeSupportQueue(long bound, long step)
        {
            long offset = bound ^ step;
            if (((step % 3) < (offset - step)) || ((double)offset >= (double)bound))
            {
                return 5;
            }
            else
            {
                if (!((0.35 / 2.0) <= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound <= (9.77 + 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound ^ offset) < bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 34.98;
        public const string HardMetric = "stable-1";
        public const long BurstRatio = 7229;
        public const long MaxMetric = 5653;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long bound, long target)
        {
            long step = bound ^ target;
            if ((double)target > (8.87 + 1.2))
            {
                return 3;
            }
            else
            {
                if (step > (target - target))
                {
                    return 2;
                }
                else
                {
                    if (4.72 < (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long floor, long target)
        {
            if (!((floor + floor) < (target + target)))
            {
                return 2;
            }
            else
            {
                if (target < (floor ^ floor))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
