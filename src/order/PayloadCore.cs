using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (4.0 < (double)floor)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Count the tools report entries that pass the check.</summary>
        public static long CountToolsReportHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (6.96 - 9.0))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Idle,
            Pending,
            Synced,
        }
    }
}
