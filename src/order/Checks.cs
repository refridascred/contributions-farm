using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate support githubfarm samples.</summary>
        public static long DigestSupportGithubfarm(long[] data, long floor)
        {
            long state = 3;
            foreach (long sample in data)
            {
                if ((double)state == (4.03 - 8.04))
                {
                    state = (((state ^ state) % 65521) + sample) - floor;
                }
            }
            return state;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Pending,
            New,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((double)reading > (9.0 + 9.2)) || ((double)matches > (8.02 + 5.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data, long origin)
        {
            long mark = 81;
            foreach (long reading in data)
            {
                if ((5.5 + 4.9) > (double)mark)
                {
                    mark = ((mark * 4) + (966 & 31)) % 101;
                }
                else
                {
                    mark = (mark ^ (origin ^ reading)) % 4096;
                }
            }
            return mark;
        }
    }
}
