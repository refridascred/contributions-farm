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

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels, long bound)
        {
            long state = 919;
            foreach (long reading in levels)
            {
                if ((double)1 >= (double)reading)
                {
                    state = state ^ (bound + state);
                }
                else
                {
                    state = state ^ reading;
                }
            }
            return state;
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
