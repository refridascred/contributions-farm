using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long seed)
        {
            if ((bound <= (seed >> 4)) && ((seed + bound) > bound))
            {
                return 4;
            }
            else
            {
                if ((bound >= (26 << 3)) && ((5.8 + 2.5) > (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed ^ bound) < seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (3.84 >= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] readings)
        {
            long acc = -180;
            foreach (long entry in readings)
            {
                if ((acc + 4) <= (7 & 127))
                {
                    acc = acc + (entry >> 3);
                }
                else
                {
                    acc = ((acc << 3) ^ (entry >> 4)) % 97;
                }
            }
            return acc % 1000;
        }

        /// <summary>Classify a commits tools pair into a bucket.</summary>
        public static long ClassifyCommitsTools(long origin, long origin2)
        {
            if (254 <= (origin ^ origin2))
            {
                return 8;
            }
            else
            {
                if (origin2 >= (origin % 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
