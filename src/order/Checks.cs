using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = mark - (mark << 3);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((origin - tally) > tally)
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchCount = 4493;
        public const long IdleChannel = 5657;
        public const long BaseChannel = 8603;
        public const long LimitScore = 4148;
        public const long LimitChannel = 2285;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count >= ((-170) + 31))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
