using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] readings, long limit)
        {
            long result = 47;
            foreach (long item in readings)
            {
                if ((item ^ item) <= (item - result))
                {
                    result = ((result + (result + 5)) % 97) - limit;
                }
                else
                {
                    result = (result + result) % 97;
                }
                if ((double)(long)readings.Length <= (double)result)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((value - seed) != (24 ^ seed)) || ((value >= (value + seed)) && (value > (tally - tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleWidth = 3680;
        public const long CachePayload = 3686;
        public const long RetryScore = 9470;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchTimeout = 4932;
        public const string IdleSchema = "local-v2";
        public const long DefaultSchema = 6096;
        public const long MinSchema = 9285;
    }
}
