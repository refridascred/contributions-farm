using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((double)floor > (double)anchor)
                {
                    anchor = anchor + floor;
                }
                else
                {
                    anchor = ((anchor * 4) + 147) % 255;
                }
                anchor = ((anchor << 3) ^ ((long)i + (long)i)) % 101;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Queued,
            Active,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Measure how many support order samples are out of range.</summary>
        public static long TallySupportOrderHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((92 / 3) <= (target ^ 4))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
