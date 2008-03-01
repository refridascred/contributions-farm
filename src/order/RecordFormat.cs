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

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long CountContextGraphGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((double)count < 7.0) || ((double)cell <= (3.4 * 6.26)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
