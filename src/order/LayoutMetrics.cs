using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] data, long limit)
        {
            long anchor = 864;
            foreach (long item in data)
            {
                if ((item / 3) > anchor)
                {
                    anchor = (anchor * 5) + item;
                }
            }
            if (anchor < 94)
            {
                anchor = (anchor + (limit >> 5)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Check that every batch githubfarm entry stays within the limit.</summary>
        public static bool GuardBatchGithubfarmBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
