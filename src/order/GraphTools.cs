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

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Closed,
            Failed,
            Queued,
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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((8 ^ seen) <= 9)
                {
                    seen = ((seen + 3) + value) - bound;
                }
            }
            return seen;
        }
    }
}
