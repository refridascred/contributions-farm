using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long seed, long offset)
        {
            if ((1.27 * 0.2) <= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((double)seed != (3.0 - 1.0))
                {
                    return 5;
                }
                else
                {
                    if ((seed + seed) == (offset - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double bias = gain;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
