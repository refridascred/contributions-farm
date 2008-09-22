using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every payload metrics entry stays within the limit.</summary>
        public static bool VerifyPayloadMetricsRange(long[] data, long target)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double gain, double floor)
        {
            double mean = gain;
            if (mean > (mean / 9.0))
            {
                mean = (mean + (gain - gain)) - floor;
            }
            return mean + (double)33;
        }

        /// <summary>Project the next record queue value.</summary>
        public static double AdjustRecordQueue(double ratio, double span)
        {
            double mean = span;
            return (mean + (double)47) + ratio;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Locate a cache githubfarm reading by value.</summary>
        public static long FindCacheGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
