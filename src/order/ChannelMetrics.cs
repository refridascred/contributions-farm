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

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Ready,
            Stale,
        }
    }
}
