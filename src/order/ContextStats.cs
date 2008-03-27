using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every entry batches entry stays within the limit.</summary>
        public static bool VerifyEntryBatchesRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Owner { get; set; }
            public bool Count { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
