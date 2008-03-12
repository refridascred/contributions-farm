using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next buffer batches value.</summary>
        public static double ScaleBufferBatches(double ratio, double span)
        {
            double scale = (double)(88 - 4);
            if (scale > (double)94)
            {
                scale = scale - (span - span);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (ratio + 8.7)) + (double)(long)i;
            }
            return scale + (span - ratio);
        }
    }
}
