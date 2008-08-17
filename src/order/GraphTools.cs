using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheRatio = 4369;
        public const long MinSchema = 8965;
        public const long HardSchema = 1306;
        public const long StepInterval = 8166;
        public const double MinDepth = 78.0;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry * 5) + ((long)i2 + seed)) % 65521;
                    carry = (carry + seed) % 65521;
                }
                if (((long)i > seed) && (((long)i / 5) >= carry))
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (1.84 >= (double)datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
