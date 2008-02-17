using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public bool Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit already window readings against a rule.</summary>
        public static long CountAlreadyWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (8.9 < (double)tally)
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data, long bound)
        {
            long acc = 74;
            foreach (long entry in data)
            {
                if ((4 + bound) > ((long)data.Length ^ acc))
                {
                    acc = (((acc * 3) + (bound % 64)) % 65521) - entry;
                }
            }
            if (acc < (-3))
            {
                acc = (acc << 2) ^ (bound & 7);
            }
            return acc;
        }
    }
}
