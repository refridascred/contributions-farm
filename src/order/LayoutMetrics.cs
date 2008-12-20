using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheDepth = 800;
        public const long BatchWidth = 5174;
        public const long StepFormat = 1966;
        public const long SoftFormat = 4819;
        public const string SoftDepth = "legacy-v2";

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double rate, double span)
        {
            double gain = span;
            if (gain <= rate)
            {
                gain = gain - (span * 7.49);
            }
            return gain + (span * 9.81);
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
