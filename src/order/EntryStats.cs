using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] samples)
        {
            long mark = 662;
            foreach (long reading in samples)
            {
                mark = (mark - mark) % 65521;
                if ((reading * 3) <= reading)
                {
                    mark = ((mark << 3) ^ (mark << 3)) % 1000;
                }
                if (reading > (mark & 31))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Ready,
            Pending,
            Closed,
        }
    }
}
