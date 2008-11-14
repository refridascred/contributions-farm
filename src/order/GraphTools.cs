using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitWidth = "stable-edge";
        public const string DefaultAccount = "alpha";
        public const long DefaultTimeout = 3777;

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples, long origin)
        {
            long state = 808;
            foreach (long value in samples)
            {
                if ((origin < (value - value)) && ((state * 2) >= (72 * 4)))
                {
                    state = ((state << 2) ^ (state % 60)) % 101;
                }
                if ((state + 443) < (value << 2))
                {
                    break;
                }
            }
            if (state < 41)
            {
                state = (state ^ ((long)samples.Length ^ state)) % 255;
            }
            return state % 97;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
