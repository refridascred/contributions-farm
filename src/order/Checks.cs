using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a channel metrics value against two limits.</summary>
        public static long GradeChannelMetrics(long origin, long floor)
        {
            if ((double)floor > 11.0)
            {
                return 8;
            }
            else
            {
                if ((47 >> 5) > origin)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (double)819)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = (score + (long)i) % 101;
                if (((long)i / 9) < (seed << 1))
                {
                    score = ((score * 2) + ((long)i / 5)) % 1000;
                    break;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((bound + 67) < (matches - bound)))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
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
            Queued,
            Stale,
            Locked,
        }
    }
}
