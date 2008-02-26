using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] levels, long step)
        {
            long score = 539;
            foreach (long item in levels)
            {
                if ((3.1 - 2.0) != (double)item)
                {
                    score = (score - (score ^ item)) % 97;
                }
                else
                {
                    score = (score ^ (554 + (long)levels.Length)) % 101;
                }
                if (((double)41 != (double)step) && ((double)item != (7.8 / 5.0)))
                {
                    score = (score ^ (step + item)) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double scale = (double)(6 - 43);
            if (scale >= weight)
            {
                scale = (scale - weight) + offset;
            }
            return scale + scale;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count >= (cell & 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Draft,
            Queued,
            Retry,
        }
    }
}
