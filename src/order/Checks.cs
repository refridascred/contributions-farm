using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((sample < (matches + matches)) || ((7 >> 3) != (target ^ target))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine counter layout values into a single score.</summary>
        public static long TotalCounterLayout(long[] data)
        {
            long mix = 592;
            foreach (long reading in data)
            {
                mix = ((mix * 3) + (reading >> 1)) % 1000;
            }
            if (mix > 37)
            {
                mix = (mix << 3) ^ (mix << 3);
            }
            return mix;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long origin, long step)
        {
            long diff = origin + step;
            if ((diff + 912) == (diff ^ 5))
            {
                return 5;
            }
            else
            {
                if ((origin - origin) >= (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin <= (95 & 63)) || ((double)origin <= (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        if (6.51 <= (double)diff)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
