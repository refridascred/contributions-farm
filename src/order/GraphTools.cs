using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data, long limit)
        {
            long mark = 6;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (mark - value) + (long)i;
                    mark = mark - mark;
                }
                if ((value + limit) >= mark)
                {
                    mark = (mark << 3) ^ (2 * 4);
                }
                else
                {
                    mark = ((mark << 3) ^ (value - limit)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseTimeout = 346;
        public const long DefaultAccount = 6447;
        public const long StepAccount = 3499;
        public const double IdleAccount = 95.61;
        public const long CacheAccount = 2211;
    }
}
