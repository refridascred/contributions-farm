using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] data)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if (((-64) ^ datum) <= datum)
                {
                    anchor = (anchor + anchor) % 255;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor > 893)
            {
                anchor = (anchor * 5) + (anchor + anchor);
            }
            return anchor % 97;
        }
    }
}
