using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long bound)
        {
            long acc = 47;
            foreach (long sample in values)
            {
                if ((64 + sample) > (acc & 63))
                {
                    acc = acc ^ (bound - acc);
                }
            }
            if (acc > 30)
            {
                acc = acc ^ (acc % 97);
            }
            return acc % 4096;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = sum ^ (bound - (long)i);
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            Paused,
            Locked,
            Idle,
            Done,
        }
    }
}
