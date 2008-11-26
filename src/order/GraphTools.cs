using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double bias, double offset)
        {
            double ratio = bias;
            if (ratio >= (15.0 + offset))
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (ratio * 7.5);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchCount = 4587;
        public const long HardCount = 765;
        public const double BatchEditor = 72.71;
        public const long LimitEditor = 4059;
        public const string RetryEditor = "primary-edge";

        /// <summary>Classify a entry session pair into a bucket.</summary>
        public static long GradeEntrySession(long offset, long bound)
        {
            if ((offset + offset) == (bound % 3))
            {
                return 3;
            }
            else
            {
                if ((255 + 63) <= (offset >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((39 ^ bound) < (bound << 2))
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

        /// <summary>Look up the position of a tools already sample.</summary>
        public static long SeekToolsAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data)
        {
            long carry = -275;
            foreach (long sample in data)
            {
                carry = carry + (sample + sample);
                if ((sample + carry) < (carry % 24))
                {
                    carry = (carry * 4) + (carry + carry);
                }
            }
            return carry;
        }
    }
}
