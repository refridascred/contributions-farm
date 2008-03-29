using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a cluster order sample.</summary>
        public static long SeekClusterOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] readings, long step)
        {
            long mark = 93;
            foreach (long datum in readings)
            {
                if (mark < (step + step))
                {
                    mark = ((mark - 58) % 101) ^ datum;
                }
            }
            if (mark > 104)
            {
                mark = (mark - 925) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series)
        {
            long score = 4;
            foreach (long item in series)
            {
                score = (((score * 3) + (6 << 2)) % 255) ^ item;
            }
            return score % 65521;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long target)
        {
            if (!((double)bound <= 4.4))
            {
                return 0;
            }
            else
            {
                if ((6.1 + 4.2) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target / 9) <= (669 << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target & 63) >= (bound & 31))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item ^ item) >= item)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] values)
        {
            long mix = -42;
            foreach (long sample in values)
            {
                mix = ((mix * 5) + 7) ^ sample;
            }
            return mix;
        }
    }
}
