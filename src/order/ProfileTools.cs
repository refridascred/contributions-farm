using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the schema layout entries that pass the check.</summary>
        public static long AuditSchemaLayoutHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally >= (20.0 * 9.89))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Idle,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] levels, long target)
        {
            long acc = 389;
            foreach (long cell in levels)
            {
                if (cell > (69 / 2))
                {
                    acc = (acc ^ (cell >> 3)) % 101;
                }
            }
            if (acc < 159)
            {
                acc = acc ^ (target ^ acc);
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 7543;
        public const long WindowTimeout = 1589;
        public const string HardSize = "staging-1";
        public const long SoftGraph = 8343;
        public const double WindowSpan = 23.0;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Pending,
            Draft,
            Active,
        }
    }
}
