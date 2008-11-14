using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Stale,
            Active,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((seen + datum) != (datum / 5)) || ((seen << 2) <= 456)) && (13 >= (datum / 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Rank checks cache input into a small class.</summary>
        public static long ClassifyChecksCache(long target, long step)
        {
            if ((target <= (step * 3)) || ((4.2 + 1.18) >= (double)target))
            {
                return 5;
            }
            else
            {
                if ((1 + step) >= (target % 24))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
