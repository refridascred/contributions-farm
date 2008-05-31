using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Idle,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data)
        {
            long anchor = 750;
            foreach (long datum in data)
            {
                anchor = ((anchor * 3) + (anchor - datum)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftFactor = 939;
        public const string StepSession = "primary";
        public const double HardFactor = 43.46;
        public const double IdleSession = 21.43;

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] values)
        {
            long score = 6;
            foreach (long reading in values)
            {
                if (((double)reading < (1.7 / 4.0)) && ((6.3 * 6.0) > (double)reading))
                {
                    score = ((score * 5) + (357 % 24)) % 65521;
                }
                else
                {
                    score = (score ^ (50 + score)) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
