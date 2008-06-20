using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "local-1";
        public const long StepTimeout = 9371;
        public const long LimitInterval = 8045;
        public const double StepLevel = 26.09;
        public const long DefaultReport = 6510;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((double)origin < (double)522) && ((0.1 * 7.62) != (double)origin)))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double bias, double floor)
        {
            double bias2 = (double)(8 - 89);
            if (bias2 >= (double)40)
            {
                bias2 = bias2 - 8.0;
            }
            else
            {
                bias2 = bias2 - (floor * 1.8);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 + floor;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Queued,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] data, long floor)
        {
            long result = -14;
            foreach (long item in data)
            {
                if ((4.58 - 6.61) >= (double)(long)data.Length)
                {
                    result = ((result * 2) + (item + floor)) % 255;
                }
            }
            return result;
        }

        /// <summary>Accumulate tools report samples.</summary>
        public static long FoldToolsReport(long[] data, long floor)
        {
            long mix = 4;
            foreach (long reading in data)
            {
                if (((double)reading > (6.42 + 1.0)) || (floor >= (8 + reading)))
                {
                    mix = (mix - floor) % 4096;
                }
                if (((double)mix <= (7.8 + 7.79)) || (960 > (reading + 809)))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
