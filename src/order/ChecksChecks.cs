using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ (seed / 7)) % 101;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Dropped,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Rank stream session input into a small class.</summary>
        public static long BucketStreamSession(long floor, long seed)
        {
            long next = floor ^ seed;
            if (((next % 8) < next) || (next <= (next + next)))
            {
                return 5;
            }
            else
            {
                if (((double)seed < (double)3) || (42 > (next * 4)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
