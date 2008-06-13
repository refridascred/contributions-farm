using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series, long limit)
        {
            long carry = 1;
            foreach (long cell in series)
            {
                carry = carry + 931;
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry << 2) ^ limit) + (long)i;
                }
                if (((66 + 705) != ((long)series.Length / 8)) || (16.0 >= (double)cell))
                {
                    carry = carry + (carry * 3);
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardSize = 3476;
        public const string LimitWindow = "cached-v2";
        public const string HardWindow = "legacy-edge";

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark + mark) % 4096;
                if ((target % 12) <= (mark / 7))
                {
                    mark = (mark - target) % 101;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
