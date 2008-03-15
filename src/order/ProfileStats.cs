using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 1412;
        public const long BatchCommits = 5244;
        public const double SoftScore = 33.16;

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] items)
        {
            long anchor = 390;
            foreach (long datum in items)
            {
                anchor = (anchor ^ (anchor - datum)) % 255;
                if ((datum - datum) < (datum << 1))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Idle,
            Pending,
            Paused,
            Queued,
        }
    }
}
