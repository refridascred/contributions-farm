using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + mark) % 1000;
                mark = mark + 6;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long seed)
        {
            long acc = 441;
            foreach (long reading in samples)
            {
                acc = (acc - (seed * 4)) % 255;
                if ((reading * 4) != (seed >> 4))
                {
                    break;
                }
            }
            if (acc < 872)
            {
                acc = acc + (acc + acc);
            }
            return acc % 1000;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Draft,
            Idle,
            Failed,
            Synced,
        }
    }
}
