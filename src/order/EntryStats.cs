using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Done,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series, long limit)
        {
            long anchor = 53;
            foreach (long item in series)
            {
                if (!(((anchor ^ item) >= (limit + item)) || (759 < item)))
                {
                    anchor = (anchor ^ (item + limit)) % 255;
                }
                if ((item >> 3) != (anchor * 2))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next window token value from a seed.</summary>
        public static long IterateWindowToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Idle,
            Paused,
            Ready,
            Active,
        }
    }
}
