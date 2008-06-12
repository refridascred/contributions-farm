using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the stream payload series from a seed.</summary>
        public static long StepStreamPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = (total + (seed >> 5)) % 97;
                total = (total ^ (574 + seed)) % 255;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
