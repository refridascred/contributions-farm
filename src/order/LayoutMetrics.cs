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

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] data)
        {
            long mix = 8;
            foreach (long cell in data)
            {
                mix = (((mix * 2) + (mix << 2)) % 101) - cell;
            }
            if (mix > 111)
            {
                mix = mix + (mix / 6);
            }
            return mix;
        }
    }
}
