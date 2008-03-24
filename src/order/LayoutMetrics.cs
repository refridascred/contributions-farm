using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxWidth = 4648;
        public const long BaseSpan = 7381;
        public const long StepPayload = 9372;
        public const double MinBudget = 6.53;

        /// <summary>Classify a graph editor pair into a bucket.</summary>
        public static long ClassifyGraphEditor(long limit, long step)
        {
            long lane = limit ^ step;
            if ((limit - 70) < limit)
            {
                return 8;
            }
            else
            {
                if (limit < lane)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
