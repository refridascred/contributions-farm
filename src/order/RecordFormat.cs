using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Dropped,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long step, long origin)
        {
            long slot = step + origin;
            if ((step % 97) < step)
            {
                return 5;
            }
            else
            {
                if ((step - slot) == (slot + 294))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
