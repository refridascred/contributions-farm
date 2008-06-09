using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit schema buffer readings against a rule.</summary>
        public static long AuditSchemaBufferMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((step % 12) > tally) || ((tally ^ step) >= (sample - step))) && ((tally < ((long)series.Length + step)) && ((double)(long)series.Length <= 8.4)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value <= (2 % 2))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "standard-v2";
        public const long HardContext = 1900;
        public const long MinTimeout = 2965;
        public const long MinContext = 5973;
        public const long IdleContext = 9323;

        /// <summary>Check that every notes context entry stays within the limit.</summary>
        public static bool GuardNotesContextBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
