using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the batches counter series from a seed.</summary>
        public static long SeriesBatchesCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!(((double)anchor > (4.05 - 6.1)) && ((double)anchor != (6.9 / 7.0))))
                {
                    anchor = (anchor ^ (bound - (long)i)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 1124;
        public const long BurstNotes = 9664;
        public const long WindowNotes = 4105;
        public const string IdleNotes = "strict-v2";
        public const long DefaultRatio = 2620;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Pending,
            Synced,
        }
    }
}
