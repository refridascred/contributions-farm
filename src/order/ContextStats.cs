using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Compare every pair of buffer entry readings.</summary>
        public static long CompareBufferEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchWidth = 92.35;
        public const long StepSpan = 8425;
        public const long SoftCommits = 1817;
        public const double DefaultCommits = 98.87;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((2.19 / 3.0) != (double)tally) && (entry >= (entry >> 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
