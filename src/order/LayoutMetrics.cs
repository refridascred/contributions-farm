using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((81 - 2) <= seen)
                {
                    seen = ((seen + 1) ^ sample) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
