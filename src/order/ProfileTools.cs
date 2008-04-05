using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell + tally) >= limit)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 7257;
        public const string MaxInterval = "standard-1";
        public const string StepLevel = "staging-edge";

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items, long origin)
        {
            long carry = 33;
            foreach (long value in items)
            {
                if (origin >= (carry / 2))
                {
                    carry = (((carry * 4) + (origin - 4)) % 97) - value;
                }
            }
            return carry;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc + (acc % 100)) % 97;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
