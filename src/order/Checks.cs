using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            New,
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Project the next record counter value.</summary>
        public static double AdjustRecordCounter(double weight, double floor)
        {
            double ratio = weight;
            if (ratio <= floor)
            {
                ratio = ratio - (floor / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] data, long target)
        {
            long carry = 501;
            foreach (long sample in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (carry + (99 ^ sample)) + (long)i;
                }
                carry = (carry + sample) % 255;
                if (((carry % 12) < target) && ((carry << 3) > (sample & 15)))
                {
                    carry = carry ^ (carry * 3);
                }
            }
            return carry;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((3.73 * 9.4) < (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 6756;
        public const double WindowCount = 67.26;
        public const long BaseSize = 3078;
        public const double BatchBatches = 92.44;
    }
}
