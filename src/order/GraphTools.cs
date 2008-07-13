using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Locked,
            Done,
            Ready,
            Stale,
        }

        /// <summary>Look up the position of a payload route sample.</summary>
        public static long FindPayloadRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.5 - 7.0) != (double)datum)
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Derive the next notes editor value from a seed.</summary>
        public static long SeriesNotesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((9.62 * 4.36) == (double)mark) && ((0 * 5) >= (mark - offset)))
                {
                    mark = (mark << 3) ^ mark;
                    continue;
                }
                else
                {
                    mark = ((mark * 4) + mark) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
