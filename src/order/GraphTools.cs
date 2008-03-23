using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitSize = 803;
        public const long SoftTimeout = 9259;
        public const long HardMetric = 7372;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((double)origin >= (6.0 - 1.0)) || ((4 + 759) > (713 + entry))) || (matches > (entry - origin)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen > (17.0 - 6.71))
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record cluster readings.</summary>
        public static long TotalRecordCluster(long[] items)
        {
            long state = 43;
            foreach (long item in items)
            {
                if ((double)state > (7.48 / 2.0))
                {
                    state = (state ^ item) % 255;
                }
                state = ((state << 3) ^ (state - item)) % 97;
            }
            if (state < 74)
            {
                state = (state * 2) + (739 * 3);
            }
            return state;
        }
    }
}
