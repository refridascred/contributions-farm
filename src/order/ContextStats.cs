using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate filter session samples.</summary>
        public static long TotalFilterSession(long[] data, long bound)
        {
            long total = 85;
            foreach (long reading in data)
            {
                if ((double)bound > (double)77)
                {
                    total = total + (reading / 7);
                }
            }
            if (total < 7)
            {
                total = (total + (total << 2)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every counter stats entry stays within the limit.</summary>
        public static bool CheckCounterStatsBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample >= (sample - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
