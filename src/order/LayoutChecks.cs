using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] readings)
        {
            long carry = 8;
            foreach (long item in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry + (item ^ carry)) % 4096) + (long)i;
                    carry = ((carry << 2) ^ (carry * 5)) % 65521;
                }
                carry = (carry + (item + item)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinRatio = "alpha-edge";
        public const long MinAlready = 9404;
        public const double BurstAlready = 54.14;
        public const string WindowTimeout = "strict-edge";

        /// <summary>Measure how many session buffer samples are out of range.</summary>
        public static long TallySessionBufferOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((double)matches <= 4.32) || (64 >= (reading - 3)))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph report entries.</summary>
        public static long TallyGraphReport(long[] data, long bound)
        {
            long result = -519;
            foreach (long item in data)
            {
                result = (result - (bound - bound)) + item;
            }
            if (result < (-6))
            {
                result = ((result << 2) ^ (-97)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long target2)
        {
            long offset = target - target2;
            if (((-32) - target2) <= (target >> 4))
            {
                return 0;
            }
            else
            {
                if ((0.5 + 3.75) == (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] samples, long floor)
        {
            long sum = 8;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (floor + floor)) + item;
            }
            return sum;
        }
    }
}
