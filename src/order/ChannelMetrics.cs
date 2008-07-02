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

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long floor, long step)
        {
            if (((floor - floor) >= (step + step)) || (148 < step))
            {
                return 6;
            }
            else
            {
                if ((step % 5) > (step >> 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
