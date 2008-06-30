using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long AuditEntryLayoutMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((31 ^ entry) > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Dropped,
            Paused,
            Synced,
            Active,
            Locked,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ tally) >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the report schema series from a seed.</summary>
        public static long StepReportSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ ((long)i + target);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
