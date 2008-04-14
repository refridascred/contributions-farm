using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit batch format readings against a rule.</summary>
        public static long AuditBatchFormatGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry >= (762 + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the account schema series from a seed.</summary>
        public static long DeriveAccountSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (-34)) % 1000;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
