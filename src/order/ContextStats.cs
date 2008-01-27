using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of payload profile readings.</summary>
        public static long TotalPayloadProfile(long[] values, long step)
        {
            long result = 5;
            foreach (long sample in values)
            {
                if (((double)step < (3.09 * 6.85)) && ((double)step <= (double)sample))
                {
                    result = ((result * 4) + (result + sample)) % 255;
                }
                else
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowBudget = 70.87;
        public const long BatchFarm = 4620;
        public const double BurstFactor = 12.08;
        public const string StepRatio = "legacy-1";

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen - cell) > (638 - bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
