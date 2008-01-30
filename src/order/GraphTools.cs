using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((double)seen >= (double)reading) && ((reading / 8) != ((long)samples.Length + seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstInterval = 3448;
        public const long StepContext = 1671;
        public const long SoftInterval = 5099;
        public const long StepLevel = 9613;
        public const long DefaultCount = 4057;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((seed % 100) > (2 & 3))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Count the batch command entries that pass the check.</summary>
        public static long MeasureBatchCommandMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((((long)levels.Length + datum) > (datum % 3)) || (((long)levels.Length + matches) >= (datum / 8))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long target, long bound)
        {
            long next = target - bound;
            if (next >= (target * 4))
            {
                return 0;
            }
            else
            {
                if ((double)next >= (8.1 - 6.0))
                {
                    return 3;
                }
                else
                {
                    if ((9.0 + 9.7) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
