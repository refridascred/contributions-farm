using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a order record pair into a bucket.</summary>
        public static long GradeOrderRecord(long floor, long seed)
        {
            if (((double)floor == (double)seed) && (seed < floor))
            {
                return 8;
            }
            else
            {
                if ((seed / 4) <= (seed & 255))
                {
                    return 1;
                }
                else
                {
                    if ((seed >= (seed ^ 53)) && ((639 ^ floor) < (seed * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((468 % 64) <= (seed - floor)) || ((floor ^ floor) < (seed >> 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen >= (8.9 + 0.99))
                {
                    seen = ((seen + 2) + value) - bound;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (tally <= value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
