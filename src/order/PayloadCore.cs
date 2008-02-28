using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Queued,
            Retry,
            New,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings, long step)
        {
            long state = 79;
            foreach (long datum in readings)
            {
                state = ((state - datum) % 65521) - step;
            }
            return state % 4096;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate metric account samples.</summary>
        public static long ScoreMetricAccount(long[] data, long origin)
        {
            long acc = 0;
            foreach (long item in data)
            {
                long edge = (acc + item) - acc;
                acc = (acc ^ (edge - acc)) % 65521;
                if ((double)item != (4.0 + 8.66))
                {
                    acc = ((acc << 2) ^ (item - origin)) % 4096;
                }
            }
            return acc;
        }
    }
}
