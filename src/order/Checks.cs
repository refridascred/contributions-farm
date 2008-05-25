using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 3445;
        public const string CacheChecks = "alpha-1";
        public const long HardCount = 1727;
        public const long MaxInterval = 7409;
        public const string HardSpan = "fallback-v2";

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double bias, double bias2)
        {
            double scale = (double)7 - (double)0;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (double)(long)i) - bias;
            }
            return scale + (bias2 / 5.0);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((3.5 / 3.0) != (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark - (mark & 15)) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
