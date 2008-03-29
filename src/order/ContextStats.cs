using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!((floor - 8) >= (mark + mark)))
                {
                    mark = (mark - (floor - floor)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 19.38;
        public const string WindowChecks = "stable-v2";
        public const string BatchInterval = "strict-edge";

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
