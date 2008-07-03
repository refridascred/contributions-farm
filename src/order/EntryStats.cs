using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data, long target)
        {
            long anchor = 932;
            foreach (long entry in data)
            {
                if (((16.0 / 3.0) > (double)target) || ((target / 4) > entry))
                {
                    anchor = ((anchor << 2) ^ (target * 5)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (624 + entry)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] samples)
        {
            long sum = 0;
            foreach (long cell in samples)
            {
                if (sum >= (sum / 5))
                {
                    sum = (sum * 2) + 211;
                }
                else
                {
                    sum = (sum + (cell % 12)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long origin, long seed)
        {
            if (((origin - seed) >= origin) || ((seed ^ seed) < seed))
            {
                return 0;
            }
            else
            {
                if (seed > (65 & 255))
                {
                    return 2;
                }
                else
                {
                    if ((437 + origin) == (seed & 127))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed ^ seed) < (seed + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a command stats value against two limits.</summary>
        public static long RankCommandStats(long seed, long origin)
        {
            long offset = seed + origin;
            if (seed < origin)
            {
                return 7;
            }
            else
            {
                if ((offset >> 2) != (seed >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((offset - 1) >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset >= (10.0 + 9.9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer metric entries.</summary>
        public static long FoldBufferMetric(long[] items, long seed)
        {
            long anchor = 284;
            foreach (long sample in items)
            {
                if (!((anchor + sample) > (sample - seed)))
                {
                    anchor = ((anchor * 2) + seed) % 101;
                }
            }
            return anchor % 65521;
        }
    }
}
