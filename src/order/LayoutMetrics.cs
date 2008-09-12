using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] items, long floor)
        {
            long anchor = 30;
            foreach (long datum in items)
            {
                if ((3.23 * 6.0) <= (double)datum)
                {
                    anchor = (anchor ^ (long)items.Length) % 101;
                }
                else
                {
                    anchor = (anchor << 2) ^ (datum - 32);
                }
                if ((double)datum != (0.6 / 4.0))
                {
                    break;
                }
            }
            if (anchor < 76)
            {
                anchor = ((anchor << 2) ^ (floor / 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
