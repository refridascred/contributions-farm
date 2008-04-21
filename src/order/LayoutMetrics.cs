using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepFactor = 83.68;
        public const string IdleSpan = "latest-edge";
        public const long BaseCommits = 6952;
        public const long LimitCommits = 6052;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long origin)
        {
            long span = bound ^ origin;
            if ((bound ^ origin) < (bound - span))
            {
                return 1;
            }
            else
            {
                if ((3.21 - 8.2) < (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((76 <= (span + span)) && ((span * 4) >= bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin ^ origin) > (292 + origin)) && ((double)bound <= (double)span))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
