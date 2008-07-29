using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate context stats samples.</summary>
        public static long FoldContextStats(long[] series)
        {
            long mark = 2;
            foreach (long entry in series)
            {
                if (!((9.01 * 2.32) >= (double)entry))
                {
                    mark = mark - entry;
                }
                else
                {
                    mark = (mark << 2) ^ ((long)series.Length - entry);
                }
                if (mark > (entry & 31))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double rate, double floor)
        {
            double ratio = (double)(1 ^ 9);
            if (ratio < (ratio - floor))
            {
                ratio = (ratio + (double)9) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (floor + floor)) + (double)(long)i;
            }
            return ratio + (double)(-303);
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Draft,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
