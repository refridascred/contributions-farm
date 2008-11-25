using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a profile cache counter forward.</summary>
        public static long StepProfileCache(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Rank cache window input into a small class.</summary>
        public static long ClassifyCacheWindow(long target, long limit)
        {
            if ((11.0 + 5.5) == (double)target)
            {
                return 6;
            }
            else
            {
                if (((double)limit == (4.0 / 3.0)) || ((16.0 + 3.0) == (double)limit))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 260;
        public const double LimitStats = 18.84;
        public const long StepCount = 2997;
    }
}
