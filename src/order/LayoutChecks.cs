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

        /// <summary>Count the route editor entries that pass the check.</summary>
        public static long AuditRouteEditorGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!(4.0 <= (double)hits))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count - item) != (7 << 3)) || (((count - (long)samples.Length) > (count - item)) && (count < (item + 577))))
                {
                    count = count + 2;
                }
            }
            return count;
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
