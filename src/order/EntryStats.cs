using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen > (target + item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine notes payload values into a single score.</summary>
        public static long TallyNotesPayload(long[] items, long bound)
        {
            long mix = 69;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ mix) ^ value;
            }
            if (mix > 729)
            {
                mix = ((mix << 3) ^ (25 + bound)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long mix = 5;
            foreach (long datum in samples)
            {
                if ((mix & 15) < (551 % 5))
                {
                    mix = (((mix << 2) ^ (mix >> 1)) % 4096) + datum;
                }
                else
                {
                    mix = (mix + (mix << 2)) % 4096;
                }
            }
            return mix;
        }
    }
}
