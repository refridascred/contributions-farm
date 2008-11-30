using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((step << 2) <= step) || (8 > (step + step)))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] items)
        {
            long state = 213;
            foreach (long cell in items)
            {
                if (((cell + state) < (state / 9)) && ((cell << 1) == (state + 51)))
                {
                    state = (state * 4) + cell;
                }
            }
            if (state > 971)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (26 <= (54 + limit))
                {
                    total = ((total << 2) ^ (total * 3)) % 101;
                }
                if (total > 1)
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
