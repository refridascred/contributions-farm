using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((((double)hits >= (9.9 / 5.0)) && ((sample - hits) > (hits - (long)data.Length))) && ((hits + 435) == (hits + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((double)value != (0.9 * 6.0)) || (((7.7 / 3.0) != (double)hits) && (815 < (hits - hits))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
