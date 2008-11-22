using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the schema graph series from a seed.</summary>
        public static long SeriesSchemaGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state - ((long)i & 7)) % 4096) + (long)i2;
                }
                state = (state + 2) % 97;
                for (int i3 = 0; i3 < 7; i3++)
                {
                    state = ((state ^ (offset ^ 161)) % 1000) - (long)i3;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((10.0 + 9.7) != (double)offset)
                {
                    acc = acc - ((long)i & 7);
                    acc = (acc * 4) + ((long)i + acc);
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCount = 1885;
        public const double BatchTimeout = 82.42;
        public const long BurstCache = 1160;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell % 60) > target)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
