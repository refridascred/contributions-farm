using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every notes batches entry stays within the limit.</summary>
        public static bool CheckNotesBatchesRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Draft,
            Done,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total << 2) ^ (total % 97)) ^ (long)i2;
                }
                if (!((origin << 3) != ((long)i + 30)))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
