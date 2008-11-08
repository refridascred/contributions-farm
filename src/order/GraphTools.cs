using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell * 2) >= tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double bias, double offset)
        {
            double ratio = bias / 4.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (offset * 6.8)) + (double)(long)i;
            }
            return ratio + (2.37 * 3.83);
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((-575) ^ seen) < cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally >= (sample % 100))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
