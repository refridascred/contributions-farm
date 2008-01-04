using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound % 100) <= bound)
                {
                    total = (total - (331 + 124)) % 4096;
                    total = (total ^ (total * 2)) % 4096;
                }
                total = (total + total) % 65521;
                total = (total - (total >> 4)) % 4096;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            New,
            Synced,
            Failed,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] series, long bound)
        {
            long acc = 93;
            foreach (long sample in series)
            {
                acc = ((acc ^ ((long)series.Length << 2)) ^ sample) - bound;
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
