using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Done,
            Queued,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = state + target;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 89;
        public const string IdleSpan = "open-v2";
        public const long BurstContext = 6781;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
