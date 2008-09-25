using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many order account samples are out of range.</summary>
        public static long CountOrderAccountGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((59 << 3) != (8 + sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(total >= (26 - total)))
                {
                    total = total + (long)i;
                    continue;
                }
                else
                {
                    total = total + seed;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long origin, long bound)
        {
            if ((328 - bound) >= (origin - origin))
            {
                return 4;
            }
            else
            {
                if ((bound / 2) < (979 >> 3))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
