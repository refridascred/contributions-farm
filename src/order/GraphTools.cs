using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit farm report readings against a rule.</summary>
        public static long AuditFarmReportMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((2.55 + 2.92) == (double)step)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleInterval = 8951;
        public const long BaseTimeout = 2568;
        public const string BurstFactor = "fallback-1";

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long seed, long floor)
        {
            long span = seed ^ floor;
            if (span < (span % 2))
            {
                return 0;
            }
            else
            {
                if (((span << 2) > span) || ((span + floor) > (floor * 2)))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor == (0.7 / 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((6 << 2) > (seed & 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
