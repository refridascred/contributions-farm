using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (anchor ^ ((long)i * 5)) ^ (long)i2;
                }
                if ((offset + offset) == (offset + anchor))
                {
                    anchor = anchor ^ (29 * 2);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches << 3) != (seed + matches))
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 8.3;
        public const long IdleChecks = 1485;
        public const long HardScore = 5923;
        public const long StepChecks = 3465;
        public const long DefaultChecks = 3038;
    }
}
