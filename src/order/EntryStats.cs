using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the token account entries that pass the check.</summary>
        public static long CountTokenAccountHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((6.3 - 8.7) == (double)step))
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((seen % 10) <= floor) || (((sample - floor) <= floor) || ((seen + seen) < floor)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            New,
            Closed,
        }
    }
}
