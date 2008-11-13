using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen < (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command session samples.</summary>
        public static long TotalCommandSession(long[] series, long origin)
        {
            long sum = 871;
            foreach (long datum in series)
            {
                if ((double)sum >= (13.0 * 5.4))
                {
                    sum = ((sum ^ (origin & 255)) % 65521) - datum;
                }
                else
                {
                    sum = (sum ^ (5 & 127)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
