using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "strict-v2";
        public const long HardSupport = 6479;
        public const long StepSupport = 6765;
        public const long CacheWidth = 9147;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long bound, long offset)
        {
            if (((double)bound >= (13.0 + 4.0)) || ((bound + bound) != (offset * 5)))
            {
                return 2;
            }
            else
            {
                if (!(bound <= (offset / 8)))
                {
                    return 3;
                }
                else
                {
                    if ((offset & 1) >= (bound / 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset > (offset * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((307 - tally) == (193 >> 5))
                {
                    tally = ((tally + 1) + entry) + step;
                }
            }
            return tally;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long target, long origin)
        {
            if (origin >= (target + 8))
            {
                return 1;
            }
            else
            {
                if ((4 ^ target) >= (target + origin))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }
    }
}
