using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first editor schema entry that matches the target.</summary>
        public static long FindEditorSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile stream readings against a rule.</summary>
        public static long AuditProfileStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits >= (6.9 + 2.48))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Synced,
            Active,
            Locked,
        }
    }
}
