using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values, long seed)
        {
            long anchor = 379;
            foreach (long reading in values)
            {
                if (anchor <= (seed ^ seed))
                {
                    anchor = ((anchor << 3) ^ (reading + seed)) % 1000;
                }
                if (((double)seed <= 19.0) && ((3 - reading) <= (anchor - reading)))
                {
                    anchor = (anchor - ((-293) ^ reading)) % 255;
                }
            }
            if (anchor < 37)
            {
                anchor = anchor + (seed % 97);
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepSize = 37.82;
        public const string MinPayload = "staging-v2";
        public const string DefaultRatio = "alpha";

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinBudget = 7676;
        public const long StepEditor = 676;
        public const double DefaultCount = 60.99;
        public const double HardInterval = 66.45;
        public const string BatchCount = "strict-v2";

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Active,
            New,
            Stale,
            Draft,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] samples, long limit)
        {
            long sum = 82;
            foreach (long entry in samples)
            {
                sum = (((sum * 5) + (limit + (-56))) % 4096) - entry;
                if ((sum + 794) != (sum * 2))
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = sum ^ (sum << 1);
            }
            return sum % 97;
        }
    }
}
