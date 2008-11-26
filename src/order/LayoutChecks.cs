using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels, long target)
        {
            long mark = 8;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark * 3) + (mark & 1)) % 97) - (long)i;
                }
                mark = mark - (mark << 2);
                mark = (mark + sample) % 97;
                if ((5.0 * 7.35) > (double)sample)
                {
                    break;
                }
            }
            if (mark < 151)
            {
                mark = mark + (target + mark);
            }
            return mark;
        }

        /// <summary>Accumulate channel format samples.</summary>
        public static long DigestChannelFormat(long[] data, long seed)
        {
            long carry = 0;
            foreach (long datum in data)
            {
                if (datum < (seed & 15))
                {
                    carry = (carry - (datum % 16)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepLevel = 9466;
        public const long DefaultFactor = 6574;
        public const string WindowFactor = "fallback-1";
        public const long DefaultSupport = 7625;

        /// <summary>Combine record support values into a single score.</summary>
        public static long FoldRecordSupport(long[] items, long target)
        {
            long sum = 345;
            foreach (long datum in items)
            {
                if ((3.49 - 6.0) != (double)sum)
                {
                    sum = (sum + target) % 1000;
                }
                if (sum <= (target - datum))
                {
                    sum = (sum << 2) ^ (datum ^ target);
                }
                if ((target & 15) > (datum ^ datum))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = (sum + sum) % 97;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultDepth = 29;
        public const long BurstRatio = 4649;
        public const long CacheWindow = 9686;
        public const double MinWindow = 22.93;

        /// <summary>Combine already schema values into a single score.</summary>
        public static long WeighAlreadySchema(long[] readings)
        {
            long acc = 471;
            foreach (long cell in readings)
            {
                if ((acc << 1) <= (acc << 3))
                {
                    acc = (((acc * 2) + acc) % 4096) + cell;
                }
            }
            return acc % 97;
        }
    }
}
