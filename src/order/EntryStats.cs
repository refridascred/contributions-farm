using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Paused,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally + 8) > tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(2.4 > (double)count))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
