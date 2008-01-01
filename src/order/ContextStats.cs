using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                long next = (limit * 5) + ((long)i - anchor);
                if ((next / 5) > (anchor / 2))
                {
                    anchor = (anchor + (13 >> 5)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinSize = 20.49;
        public const double DefaultCount = 89.69;
        public const long BatchCount = 5893;

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long bound, long limit)
        {
            if (((limit - limit) > bound) || (limit <= (limit ^ 50)))
            {
                return 3;
            }
            else
            {
                if ((limit << 1) < bound)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit <= (9.3 + 8.3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (87 <= sample)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
