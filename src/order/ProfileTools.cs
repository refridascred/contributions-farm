using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Synced,
            New,
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Rank tools batch input into a small class.</summary>
        public static long SortToolsBatch(long step, long origin)
        {
            long bound = step ^ origin;
            if ((68 << 1) == (step + bound))
            {
                return 8;
            }
            else
            {
                if (((double)bound == (0.3 * 2.5)) || (11.0 >= (double)step))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
