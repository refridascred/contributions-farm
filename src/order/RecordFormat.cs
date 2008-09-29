using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double span)
        {
            double gain = ratio - span;
            if (gain >= (ratio + span))
            {
                gain = gain - 17.0;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (2.07 * 5.4)) - (double)(long)i;
            }
            return gain - (double)78;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] series)
        {
            long state = 89;
            foreach (long cell in series)
            {
                state = (((state << 3) ^ (state << 3)) % 65521) + cell;
            }
            if (state > 2)
            {
                state = (state + (state << 2)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Paused,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Done,
            Paused,
        }
    }
}
