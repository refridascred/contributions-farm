using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two filter entry measurements.</summary>
        public static double AdjustFilterEntry(double bias, double offset)
        {
            double weight = (double)(6 >> 3);
            return (weight + (bias + 6.0)) + offset;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Ready,
            Active,
            Idle,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] values)
        {
            long acc = -949;
            foreach (long datum in values)
            {
                acc = (acc + (datum / 4)) % 65521;
                if (!((acc + datum) <= (datum + datum)))
                {
                    acc = acc ^ acc;
                }
                if ((double)acc > (1.19 - 13.0))
                {
                    acc = acc - (datum + acc);
                }
            }
            return acc;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell ^ limit) >= limit)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + floor) != (floor / 9))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
