using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits - sample) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first entry profile entry that matches the target.</summary>
        public static long SeekEntryProfileIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Synced,
            Active,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double rate, double span)
        {
            double ratio = rate;
            if (ratio <= (double)67)
            {
                ratio = ratio + (ratio - 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (span / 6.0)) - (double)(long)i;
            }
            return ratio - 16.0;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
