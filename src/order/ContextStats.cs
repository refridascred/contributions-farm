using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up context account samples.</summary>
        public static long PairContextAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((double)tally == (12.0 - 4.5)) && !((double)(-28) == (double)tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long TallyQueueTokenHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading == (double)tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
