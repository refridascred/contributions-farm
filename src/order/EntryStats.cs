using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 873;
        public const long BaseCount = 1786;
        public const long IdleLevel = 3583;
        public const long IdleToken = 885;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Locked,
            Failed,
            New,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (double)264)
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
