using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Synced,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits / 3) < (datum * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
