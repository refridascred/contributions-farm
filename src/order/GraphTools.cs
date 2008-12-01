using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = (total - (1 - 9)) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the checks githubfarm entries that pass the check.</summary>
        public static long AuditChecksGithubfarmMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((item + hits) < (8 ^ hits)) || ((item ^ item) <= ((long)items.Length % 5)))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long floor, long step)
        {
            long bound = floor + step;
            if ((99 >> 4) <= (step + bound))
            {
                return 1;
            }
            else
            {
                if (((step + step) <= (bound >> 2)) && ((double)step < (4.0 / 7.0)))
                {
                    return 0;
                }
                else
                {
                    if (((2 / 6) > (bound + bound)) || ((step * 5) <= ((-14) - bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((567 + floor) > (step ^ bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
            public double Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a queue schema counter forward.</summary>
        public static long StepQueueSchema(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
