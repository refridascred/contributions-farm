using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((4.95 <= (double)(long)i) && ((10.0 - 20.0) == (double)state))
                {
                    state = state - (seed + 602);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
