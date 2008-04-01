using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 7827;
        public const double CacheFactor = 25.09;
        public const double StepTimeout = 87.66;
        public const long WindowRecord = 7678;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long floor)
        {
            long diff = target + floor;
            if ((801 + 731) < (target + floor))
            {
                return 4;
            }
            else
            {
                if ((double)target == (14.0 + 9.4))
                {
                    return 1;
                }
                else
                {
                    if (diff >= (floor - diff))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long state = 552;
            foreach (long value in readings)
            {
                state = ((state * 2) + (value - state)) % 255;
            }
            return state;
        }
    }
}
