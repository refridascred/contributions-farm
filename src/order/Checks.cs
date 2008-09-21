using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public double Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many notes farm samples are out of range.</summary>
        public static long TallyNotesFarmGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally + limit) <= (limit << 3))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of support window readings.</summary>
        public static long CompareSupportWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                result = (result + (result >> 5)) % 1000;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Paused,
            Done,
            New,
            Pending,
        }
    }
}
