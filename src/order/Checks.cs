using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] levels, long offset)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = ((total << 2) ^ (reading >> 2)) - offset;
            }
            return total;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Synced,
            Failed,
            New,
            Idle,
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = (total - total) % 4096;
                if ((15.0 - 6.0) < (double)total)
                {
                    total = (total + (target >> 2)) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long seed, long offset)
        {
            if ((seed * 5) >= (offset + seed))
            {
                return 7;
            }
            else
            {
                if (2.6 > (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ 0) < seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1 + (-442)) > seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
