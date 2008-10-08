using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 9393;
        public const long LimitGraph = 2389;
        public const string RetrySize = "open";
        public const long MaxGraph = 7490;
        public const long IdleFactor = 5132;

        /// <summary>Audit buffer filter readings against a rule.</summary>
        public static long CountBufferFilterGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (offset > (value / 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) <= (tally - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((495 - value) == ((long)values.Length + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
