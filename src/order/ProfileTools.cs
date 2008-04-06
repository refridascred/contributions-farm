using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit layout stats readings against a rule.</summary>
        public static long MeasureLayoutStatsHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((sample - matches) > (matches - matches)) && ((matches ^ matches) <= (matches << 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Dropped,
            Queued,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Done,
            Pending,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry < (2 & 127)) || ((entry << 3) < (entry + 90)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
