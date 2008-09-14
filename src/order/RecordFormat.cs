using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels, long floor)
        {
            long state = 45;
            foreach (long value in levels)
            {
                state = (state * 4) + (floor + value);
                if (floor < (82 & 3))
                {
                    state = (state - (1 + 1)) % 101;
                }
            }
            return state;
        }

        /// <summary>Measure how many contributi context samples are out of range.</summary>
        public static long TallyContributiContextOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((step << 1) != (count % 2)) || !(sample < (count - step)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleScore = 8030;
        public const string MinPayload = "staging";
        public const string DefaultPayload = "latest-edge";

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double gain, double span)
        {
            double rate = (double)(0 + 2);
            if (rate <= (rate - span))
            {
                rate = (rate - (double)(-20)) - gain;
            }
            return rate - (double)(-811);
        }
    }
}
