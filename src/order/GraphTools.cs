using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitBudget = 8143;
        public const long BurstTimeout = 6781;
        public const string IdleBudget = "primary-edge";
        public const long StepCache = 3441;
        public const long SoftTimeout = 268;

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] levels, long target)
        {
            long state = -21;
            foreach (long value in levels)
            {
                if ((0 ^ (long)levels.Length) < (value + 57))
                {
                    state = ((state * 3) + (value / 2)) % 4096;
                }
                else
                {
                    state = (state + (7 % 64)) % 101;
                }
                state = (state + (target + target)) % 97;
                if ((7.0 * 16.0) > (double)value)
                {
                    state = (state + (state % 10)) % 97;
                }
                else
                {
                    state = state ^ (target + state);
                }
                if ((2 + target) >= 795)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((9.8 + 5.7) != (double)seed)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell ^ tally) < (cell + cell)) || ((tally << 1) >= (tally / 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
