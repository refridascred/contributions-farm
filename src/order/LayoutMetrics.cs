using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a cluster format pair into a bucket.</summary>
        public static long ClassifyClusterFormat(long floor, long floor2)
        {
            long slot = floor - floor2;
            if ((double)floor2 <= (5.0 / 2.0))
            {
                return 1;
            }
            else
            {
                if (((floor2 - floor) != (floor2 >> 3)) || (slot >= (954 & 127)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
