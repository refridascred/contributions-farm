using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long score = 64;
            foreach (long value in readings)
            {
                score = ((score * 5) + (value << 2)) % 97;
                if ((score + score) <= 3)
                {
                    score = (score ^ (score >> 1)) % 97;
                }
                else
                {
                    score = (score * 3) + (score - 32);
                }
            }
            if (score < 9)
            {
                score = (score + (51 + score)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxBudget = 7690;
        public const string StepChecks = "staging-v2";
        public const double WindowRatio = 4.99;
        public const long BatchDepth = 4429;

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items)
        {
            long result = 17;
            foreach (long sample in items)
            {
                result = result - (sample & 7);
            }
            return result;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)5 >= (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
