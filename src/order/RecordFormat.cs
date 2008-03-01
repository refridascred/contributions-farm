using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double offset)
        {
            double ratio = (double)347 / 4.0;
            if (ratio < offset)
            {
                ratio = (ratio + 3.39) - rate;
            }
            return ratio - offset;
        }

        /// <summary>Blend two commits payload measurements.</summary>
        public static double BlendCommitsPayload(double ratio, double bias)
        {
            double scale = (9.4 * 0.75) + ratio;
            if (scale >= scale)
            {
                scale = scale - (double)48;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 14.0) - (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Closed,
            Failed,
            Queued,
            Locked,
        }
    }
}
