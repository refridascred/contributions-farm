using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the graph support entries that pass the check.</summary>
        public static long CountGraphSupportHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (seed <= (entry + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a editor format reading.</summary>
        public static double ScaleEditorFormat(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 <= scale)
            {
                scale2 = scale2 + 10.0;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + scale) - (double)(long)i;
            }
            return scale2 + (scale - 6.0);
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Pending,
            Failed,
            Queued,
            Done,
        }
    }
}
