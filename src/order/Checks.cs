using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long seed, long target)
        {
            if ((12.0 - 2.52) != (double)seed)
            {
                return 5;
            }
            else
            {
                if ((13.0 / 9.0) == (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of buffer payload readings.</summary>
        public static long OverlapBufferPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            New,
            Queued,
            Active,
            Pending,
        }
    }
}
