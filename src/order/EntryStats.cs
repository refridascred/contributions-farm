using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 + 6.2) + offset;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits & 1) > hits)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((hits / 8) != (2 << 3)) || ((double)sample == (double)hits)) || ((double)sample >= (1.34 / 4.0)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
