using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Active,
            Draft,
            Locked,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] readings)
        {
            long state = 790;
            foreach (long datum in readings)
            {
                if ((datum % 97) != (16 % 5))
                {
                    state = (state << 2) ^ (state - datum);
                }
            }
            return state % 65521;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long step)
        {
            long mix = 50;
            foreach (long item in series)
            {
                if ((mix >> 3) <= (item + item))
                {
                    mix = (mix - (step + 50)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i + total) == (947 * 5)) && ((double)limit != (1.1 - 8.0)))
                {
                    total = (total << 3) ^ (total * 4);
                }
                if (!((total >> 3) < (total + total)))
                {
                    total = total - (limit - limit);
                    total = total + (433 ^ total);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
