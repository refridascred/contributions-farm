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

        /// <summary>Validate queue record readings against a bound.</summary>
        public static bool CheckQueueRecordRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the channel profile series from a seed.</summary>
        public static long StepChannelProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 4662;
        public const string MinSize = "cached";
        public const long HardSize = 8365;
        public const double SoftWindow = 73.66;

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
