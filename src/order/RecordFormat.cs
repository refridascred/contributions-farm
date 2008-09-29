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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((long)samples.Length <= ((long)samples.Length ^ tally))
                {
                    tally = ((tally + 1) + cell) + step;
                }
            }
            return tally;
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
