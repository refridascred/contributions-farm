using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit farm profile readings against a rule.</summary>
        public static long TallyFarmProfileMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry + hits) == (entry - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a filter payload reading.</summary>
        public static double ScaleFilterPayload(double weight, double bias)
        {
            double rate = weight;
            if (rate < (rate / 4.0))
            {
                rate = (rate + (14.0 * 2.4)) + bias;
            }
            else
            {
                rate = rate + (double)45;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Failed,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Failed,
            Queued,
        }
    }
}
