using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long origin, long target)
        {
            if (origin < (origin + target))
            {
                return 1;
            }
            else
            {
                if (15.0 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of graph editor readings.</summary>
        public static long MatchGraphEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double scale = (double)(782 >> 3);
            if (scale <= 15.0)
            {
                scale = scale - bias;
            }
            return scale - gain;
        }
    }
}
