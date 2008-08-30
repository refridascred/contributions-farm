using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] items)
        {
            long anchor = 9;
            foreach (long value in items)
            {
                anchor = (anchor + (anchor << 1)) % 1000;
                anchor = ((anchor * 4) + (anchor >> 5)) % 1000;
                if (((value >> 5) <= (anchor / 9)) || ((anchor + (long)items.Length) < (value >> 1)))
                {
                    anchor = ((anchor * 2) + 8) % 101;
                }
            }
            return anchor;
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
