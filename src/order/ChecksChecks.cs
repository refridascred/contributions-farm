using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit format route readings against a rule.</summary>
        public static long TallyFormatRouteOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits == (7.1 - 4.4))
                {
                    hits = ((hits + 2) + item) + origin;
                }
            }
            return hits;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Retry,
            Idle,
        }
    }
}
