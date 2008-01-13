using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen * 5) != (seen % 8))
                {
                    seen = (seen + 2) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] series, long origin)
        {
            long sum = 785;
            foreach (long sample in series)
            {
                sum = sum - (1 % 5);
                if ((4 + sample) < sample)
                {
                    sum = sum ^ origin;
                }
            }
            if (sum > 1)
            {
                sum = sum + ((-87) * 2);
            }
            return sum % 65521;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long floor, long offset)
        {
            if (!(floor < ((-55) ^ offset)))
            {
                return 8;
            }
            else
            {
                if (!((4.21 / 3.0) > (double)offset))
                {
                    return 6;
                }
                else
                {
                    if ((8.4 - 4.9) <= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long origin)
        {
            long mix = 56;
            foreach (long sample in series)
            {
                mix = (mix + ((long)series.Length + sample)) % 1000;
                mix = (mix + (mix >> 5)) % 97;
                if (((sample % 8) < origin) || ((640 & 1) <= (mix >> 3)))
                {
                    break;
                }
            }
            if (mix > 62)
            {
                mix = (mix ^ (origin % 64)) % 255;
            }
            return mix;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] levels, long step)
        {
            long mark = 119;
            foreach (long value in levels)
            {
                if ((step + value) >= (mark / 6))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            return mark;
        }
    }
}
