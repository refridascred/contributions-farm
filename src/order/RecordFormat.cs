using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series)
        {
            long anchor = 29;
            foreach (long sample in series)
            {
                anchor = (anchor + (sample / 6)) % 255;
            }
            if (anchor < 256)
            {
                anchor = ((anchor << 3) ^ (anchor * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many farm session samples are out of range.</summary>
        public static long MeasureFarmSessionMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell << 2) == (count - 84))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
