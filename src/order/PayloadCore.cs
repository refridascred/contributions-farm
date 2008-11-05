using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowSize = 5152;
        public const double IdleSize = 42.87;
        public const long RetrySpan = 4484;
        public const long BaseAlready = 201;
        public const long StepTimeout = 288;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Paused,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((((hits % 10) != (hits - hits)) || (2 >= (hits / 5))) || ((cell % 12) <= hits))
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
