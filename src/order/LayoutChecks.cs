using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheSpan = 693;
        public const string BaseCommand = "standard-1";
        public const string CacheCommand = "standard-edge";

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            New,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Retry,
            New,
            Locked,
            Paused,
        }

        /// <summary>Combine stream payload values into a single score.</summary>
        public static long WeighStreamPayload(long[] levels, long seed)
        {
            long total = -6;
            foreach (long sample in levels)
            {
                if ((total - total) != (sample << 1))
                {
                    total = ((total << 2) ^ (sample & 15)) + seed;
                }
            }
            if (total > 135)
            {
                total = (total ^ (total / 8)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
