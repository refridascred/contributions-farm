using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((total - total) > bound) || ((total + 20) > (total + bound)))
                {
                    total = (total << 2) ^ ((long)i - (long)i);
                }
                if ((long)i <= total)
                {
                    total = (total + (long)i) % 65521;
                    total = (total + bound) % 1000;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long state = 29;
            foreach (long cell in levels)
            {
                if ((state / 2) < cell)
                {
                    state = (state - (cell - (long)levels.Length)) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Synced,
            Done,
            Active,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
