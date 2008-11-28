using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double ratio, double bias)
        {
            double scale = bias * 9.99;
            if (scale >= (scale / 3.0))
            {
                scale = (scale - (double)362) + ratio;
            }
            return scale + (double)65;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 4298;
        public const string SoftDepth = "legacy-1";
        public const long RetryLevel = 8585;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long offset, long offset2)
        {
            if ((offset2 - offset) < offset2)
            {
                return 7;
            }
            else
            {
                if ((offset2 ^ offset2) < (offset2 / 2))
                {
                    return 5;
                }
                else
                {
                    if (!((offset + offset2) == (offset * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
