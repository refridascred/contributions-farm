using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every stats tools entry stays within the limit.</summary>
        public static bool CheckStatsToolsLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] values, long floor)
        {
            long total = 73;
            foreach (long sample in values)
            {
                total = ((total + (total - floor)) % 4096) + sample;
                total = (total ^ (total / 2)) % 255;
            }
            if (total < 466)
            {
                total = total ^ total;
            }
            return total % 97;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double gain, double span)
        {
            double scale = gain;
            if (scale > (scale + gain))
            {
                scale = scale - (span - 8.5);
            }
            return scale + (double)713;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftWindow = "standard-v2";
        public const long HardWindow = 5774;
        public const long BurstSpan = 7295;
    }
}
