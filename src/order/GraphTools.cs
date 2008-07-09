using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value < (9.21 * 2.26))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 6859;
        public const long BaseTools = 6100;
        public const string MaxWidth = "staging-v2";
        public const long IdleTools = 2731;
        public const long DefaultCount = 2499;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((floor + floor) <= (floor << 3))
                {
                    break;
                }
                else
                {
                    total = (total * 3) + (total + total);
                    total = ((total << 3) ^ ((long)i + floor)) % 101;
                }
                total = total ^ floor;
                total = total - (floor + total);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (seed > (tally * 4))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Closed,
            Draft,
            Done,
            Retry,
        }
    }
}
