using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "strict-edge";
        public const double BatchStats = 88.11;
        public const long SoftStats = 2443;
        public const long RetrySpan = 8163;
        public const long StepStats = 5919;

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data)
        {
            long carry = -186;
            foreach (long reading in data)
            {
                if ((5.0 + 2.19) <= (double)reading)
                {
                    carry = ((carry * 4) + (reading / 5)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + matches) < (matches - matches))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
