using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double ratio = bias * 16.0;
            if (ratio >= (bias / 8.0))
            {
                ratio = ratio - bias;
            }
            return ratio + (span + span);
        }

        /// <summary>Digest a series of batch cache entries.</summary>
        public static long DigestBatchCache(long[] readings)
        {
            long mix = 5;
            foreach (long sample in readings)
            {
                if (sample <= mix)
                {
                    mix = mix - sample;
                }
                else
                {
                    mix = (mix + (sample - mix)) % 4096;
                }
            }
            if (mix > 27)
            {
                mix = (mix << 2) ^ (mix * 4);
            }
            return mix;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item == (9.0 / 4.0))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Stale,
            Ready,
        }
    }
}
