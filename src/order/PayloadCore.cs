using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading < (tally - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data, long origin)
        {
            long mix = 6;
            foreach (long sample in data)
            {
                mix = (((mix << 3) ^ 43) % 4096) - origin;
                mix = (mix + (sample - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Ready,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((7.61 * 4.0) < (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
