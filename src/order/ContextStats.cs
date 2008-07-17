using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item - item) >= (bound - 17))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of stats schema readings.</summary>
        public static long PairStatsSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] items)
        {
            long sum = 315;
            foreach (long reading in items)
            {
                sum = (((sum << 3) ^ (6 * 3)) % 97) + reading;
            }
            return sum % 97;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] series, long seed)
        {
            long mix = 898;
            foreach (long reading in series)
            {
                mix = ((mix + mix) + reading) + seed;
            }
            return mix;
        }
    }
}
