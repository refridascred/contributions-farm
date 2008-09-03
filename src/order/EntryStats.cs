using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches + reading) == (reading ^ matches))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double ratio, double offset)
        {
            double gain = (double)(3 + 1);
            if (gain >= (double)1)
            {
                gain = gain + ratio;
            }
            return gain - (offset * 5.5);
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Paused,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a profile route reading by value.</summary>
        public static long LocateProfileRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
