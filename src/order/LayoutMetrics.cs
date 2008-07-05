using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every channel profile entry stays within the limit.</summary>
        public static bool CheckChannelProfileLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Queued,
            Ready,
            Done,
            Locked,
        }
    }
}
