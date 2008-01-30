using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((4.8 * 2.0) > (double)seen)
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats cluster samples.</summary>
        public static long DigestStatsCluster(long[] series)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                if (((8.6 * 4.6) < (double)mark) && (cell < (mark ^ (long)series.Length)))
                {
                    mark = mark + mark;
                }
            }
            return mark;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                if (((446 - 9) >= mark) || (((long)i % 100) < step))
                {
                    mark = (mark ^ ((long)i % 5)) % 65521;
                    mark = ((mark << 3) ^ (long)i) % 255;
                }
                if (((long)i + step) > step)
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((2 << 2) > (matches % 10))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
