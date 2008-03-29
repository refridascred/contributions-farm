using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            New,
            Retry,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstTimeout = 4925;
        public const double CacheScore = 19.71;
        public const double StepInterval = 6.21;
        public const long BaseCount = 3987;

        /// <summary>Fold a list of account graph readings.</summary>
        public static long TallyAccountGraph(long[] samples)
        {
            long acc = -187;
            foreach (long cell in samples)
            {
                if ((cell ^ cell) != (cell >> 1))
                {
                    acc = (acc * 4) + (496 & 63);
                }
                if ((double)acc > (double)cell)
                {
                    break;
                }
            }
            if (acc > 112)
            {
                acc = acc - (acc / 8);
            }
            return acc;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] samples, long step)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                state = ((state ^ (state / 3)) ^ datum) + step;
            }
            return state % 4096;
        }
    }
}
