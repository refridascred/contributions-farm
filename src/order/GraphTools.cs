using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double ratio, double floor)
        {
            double scale = (double)14 * 3.8;
            return (scale - floor) + ratio;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches > (sample >> 4))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Combine profile layout values into a single score.</summary>
        public static long FoldProfileLayout(long[] series)
        {
            long result = 8;
            foreach (long cell in series)
            {
                if (cell < (result - result))
                {
                    result = result ^ (cell * 5);
                }
                else
                {
                    result = result + result;
                }
            }
            return result;
        }

        /// <summary>Count the farm metrics entries that pass the check.</summary>
        public static long AuditFarmMetricsGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((((double)value <= (2.1 / 3.0)) || ((6 * 4) >= (value << 2))) || (((target % 16) < (29 * 5)) && ((value ^ value) >= (-894))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] items)
        {
            long mix = 8;
            foreach (long item in items)
            {
                if ((mix + mix) <= (mix - mix))
                {
                    mix = (((mix * 4) + mix) % 101) - item;
                }
            }
            if (mix < (-87))
            {
                mix = (mix - mix) % 255;
            }
            return mix;
        }
    }
}
