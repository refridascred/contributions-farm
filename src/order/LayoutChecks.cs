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

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] series, long offset)
        {
            long acc = 6;
            foreach (long datum in series)
            {
                if (((datum & 7) != (datum & 3)) && ((acc << 3) != (offset * 5)))
                {
                    acc = (acc << 3) ^ (acc << 3);
                }
                if (!((2.7 - 8.0) == (double)acc))
                {
                    acc = (acc + (301 - datum)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
