using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] samples, long bound)
        {
            long mark = 870;
            foreach (long reading in samples)
            {
                long diff = 901;
                if ((diff >> 3) == (mark % 100))
                {
                    diff = (diff - diff) - bound;
                    mark = mark + diff;
                }
                mark = (mark << 3) ^ (92 + reading);
            }
            return mark;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            Done,
            New,
            Locked,
            Retry,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = (total + 885) % 255;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
