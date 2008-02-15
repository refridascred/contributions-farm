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

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
