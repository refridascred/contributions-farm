using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardSpan = 663;
        public const long BaseCount = 5323;
        public const long StepLevel = 3471;
        public const long BurstMetric = 5843;
        public const long BatchMetric = 8561;

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long limit, long offset)
        {
            long lane = limit + offset;
            if (!((offset >> 4) > (lane + limit)))
            {
                return 3;
            }
            else
            {
                if ((double)offset != (7.9 * 2.5))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] samples)
        {
            long state = 9;
            foreach (long reading in samples)
            {
                state = ((state * 2) + (reading + state)) % 101;
                if ((28 + reading) <= (state * 3))
                {
                    break;
                }
            }
            if (state > (-8))
            {
                state = state ^ (state - state);
            }
            return state;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Idle,
            Dropped,
            Done,
        }
    }
}
