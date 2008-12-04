using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)sample <= (double)tally)
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter token values into a single score.</summary>
        public static long TallyFilterToken(long[] data)
        {
            long acc = 0;
            foreach (long value in data)
            {
                if (value >= acc)
                {
                    acc = (acc + (value >> 2)) % 1000;
                }
            }
            if (acc > 2)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Validate githubfarm support readings against a bound.</summary>
        public static bool VerifyGithubfarmSupportBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public double Label { get; set; }
        }
    }
}
