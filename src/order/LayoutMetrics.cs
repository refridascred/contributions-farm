using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Synced,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Adjust a editor session reading.</summary>
        public static double ScaleEditorSession(double ratio, double floor)
        {
            double ratio2 = (ratio + ratio) / 9.0;
            return (ratio2 + (double)19) + floor;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
