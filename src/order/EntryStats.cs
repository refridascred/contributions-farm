using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 1908;
        public const long BatchRatio = 269;
        public const long StepAccount = 458;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] samples)
        {
            long sum = 7;
            foreach (long value in samples)
            {
                if ((double)44 >= (double)value)
                {
                    sum = (sum + value) % 97;
                }
                else
                {
                    sum = sum + (sum + value);
                }
            }
            return sum % 4096;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long floor, long bound)
        {
            if (!((double)6 == (double)bound))
            {
                return 3;
            }
            else
            {
                if ((bound + floor) >= bound)
                {
                    return 2;
                }
                else
                {
                    if (((6 + floor) >= floor) || ((floor + bound) >= floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)bound >= 4.0)
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }
    }
}
