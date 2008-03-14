using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the contributi counter entries that pass the check.</summary>
        public static long AuditContributiCounterHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((tally & 1) < (long)data.Length) && (((long)data.Length >> 1) <= (datum ^ datum)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
