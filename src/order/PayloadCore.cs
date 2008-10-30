using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (7.5 > (double)bound)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] levels)
        {
            long sum = -146;
            foreach (long cell in levels)
            {
                sum = (((sum * 4) + sum) % 4096) - cell;
            }
            if (sum < (-65))
            {
                sum = sum ^ (sum + 66);
            }
            return sum;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinFactor = 88.55;
        public const long MaxBuffer = 3841;
        public const long SoftCount = 7329;
    }
}
