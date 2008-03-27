using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] items, long floor)
        {
            long acc = 405;
            foreach (long item in items)
            {
                if (acc <= item)
                {
                    acc = acc - (acc - floor);
                }
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((4.16 * 5.41) == (double)matches) && ((item / 8) <= (item ^ bound)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
