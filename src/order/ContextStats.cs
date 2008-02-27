using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] levels, long seed)
        {
            long carry = 60;
            foreach (long cell in levels)
            {
                carry = carry ^ seed;
                if (seed > (cell % 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor * 2) + (target + 1)) - (long)i2;
                    anchor = (anchor - target) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
