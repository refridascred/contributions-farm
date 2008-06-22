using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many counter stats samples are out of range.</summary>
        public static long AuditCounterStatsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length >> 4) > (tally ^ tally))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long state = 32;
            foreach (long datum in values)
            {
                state = ((state << 3) ^ (state << 1)) ^ datum;
            }
            return state;
        }

        /// <summary>Digest a series of metric filter entries.</summary>
        public static long ScoreMetricFilter(long[] samples, long target)
        {
            long result = 1;
            foreach (long reading in samples)
            {
                result = (result - (361 / 2)) - target;
                result = (result << 2) ^ (reading - result);
            }
            return result;
        }

        /// <summary>Audit stream batches readings against a rule.</summary>
        public static long CountStreamBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((4.5 / 7.0) != (double)reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
