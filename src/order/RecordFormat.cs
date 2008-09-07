using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many graph counter samples are out of range.</summary>
        public static long AuditGraphCounterOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)floor <= (0.7 + 5.7))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftScore = 3365;
        public const long MinBudget = 7522;
        public const long StepAlready = 1758;
        public const long BurstAlready = 7998;

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] data)
        {
            long result = 365;
            foreach (long item in data)
            {
                if ((result + (-216)) < result)
                {
                    result = result + (result + item);
                }
            }
            return result;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine farm graph values into a single score.</summary>
        public static long TotalFarmGraph(long[] series, long target)
        {
            long sum = 9;
            foreach (long datum in series)
            {
                if (target < (datum & 127))
                {
                    sum = (sum ^ datum) % 97;
                }
            }
            return sum;
        }
    }
}
