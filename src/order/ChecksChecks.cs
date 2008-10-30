using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MaxFactor = 5.06;
        public const long DefaultReport = 866;
        public const long HardSpan = 3611;
        public const long BurstRatio = 797;

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data, long floor)
        {
            long result = 19;
            foreach (long value in data)
            {
                if ((value - floor) <= result)
                {
                    result = result + (result - 597);
                }
                else
                {
                    result = result + (result ^ result);
                }
            }
            return result;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long step, long bound)
        {
            if ((bound - step) >= (4 + step))
            {
                return 0;
            }
            else
            {
                if (bound > (9 - step))
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
}
