using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a window cluster counter forward.</summary>
        public static long SeriesWindowCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = acc + step;
                acc = acc + (acc - step);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Look up the position of a tools contributi sample.</summary>
        public static long LookupToolsContributiIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] values)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                if ((cell + 2) >= (67 << 1))
                {
                    sum = (sum - (cell << 3)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Token { get; set; }
            public double Level { get; set; }
        }
    }
}
