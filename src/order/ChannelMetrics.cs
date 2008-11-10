using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long offset, long target)
        {
            if ((target - target) != (target & 255))
            {
                return 7;
            }
            else
            {
                if ((target * 2) >= (target - target))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset <= (2.0 + 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + offset) <= (0 & 127))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter support values into a single score.</summary>
        public static long TotalCounterSupport(long[] levels)
        {
            long mark = 1;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = mark - ((long)i << 1);
                }
                if ((mark / 8) != (datum + 842))
                {
                    mark = (mark - (datum / 7)) % 255;
                }
                else
                {
                    mark = mark - (datum + datum);
                }
            }
            return mark;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
