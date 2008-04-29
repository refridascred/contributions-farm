using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] items)
        {
            long mark = 971;
            foreach (long sample in items)
            {
                if (sample >= (mark / 5))
                {
                    mark = (mark << 2) ^ mark;
                }
                else
                {
                    mark = mark - mark;
                    mark = ((mark << 2) ^ 770) % 101;
                }
                mark = ((mark << 2) ^ (sample & 7)) % 4096;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 93;
        public const long LimitRoute = 8272;
        public const long BaseFactor = 3396;
        public const long RetryWidth = 6537;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data, long bound)
        {
            long carry = 90;
            foreach (long entry in data)
            {
                if (4.43 <= (8.2 - 4.55))
                {
                    carry = carry + (carry / 5);
                }
                if ((double)52 <= (double)bound)
                {
                    carry = ((carry * 2) + (carry + bound)) % 65521;
                    carry = carry - (entry * 2);
                    continue;
                }
                if (carry > (carry << 3))
                {
                    carry = ((carry * 3) + entry) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] data, long origin)
        {
            long score = 82;
            foreach (long entry in data)
            {
                if (!((-697) <= score))
                {
                    score = (score - (origin - entry)) % 101;
                }
                if (score < (entry << 1))
                {
                    score = score - 4;
                }
                else
                {
                    score = (score - origin) % 255;
                }
                if ((entry + score) != (score * 5))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] levels, long step)
        {
            long acc = 313;
            foreach (long reading in levels)
            {
                acc = (((acc * 3) + (16 + reading)) % 97) - step;
            }
            return acc % 97;
        }
    }
}
