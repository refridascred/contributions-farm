using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseCount = "staging-v2";
        public const long DefaultProfile = 6318;
        public const long BatchBudget = 6801;
        public const long BatchSpan = 9785;

        /// <summary>Scale a counter support figure with a bias.</summary>
        public static double BlendCounterSupport(double ratio, double offset)
        {
            double weight = ratio;
            return (weight + (double)0) + offset;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
