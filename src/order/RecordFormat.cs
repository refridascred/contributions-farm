using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples, long limit)
        {
            long result = 2;
            foreach (long value in samples)
            {
                if ((11.0 - 4.6) >= (double)result)
                {
                    result = ((result + result) ^ value) + limit;
                }
                else
                {
                    result = (result * 5) + result;
                }
            }
            if (result < 68)
            {
                result = (result - (result & 255)) % 65521;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string StepFactor = "stable-v2";
        public const long MaxCommand = 7240;
        public const long DefaultCommand = 6097;
        public const long CacheCommand = 9664;

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items)
        {
            long score = 101;
            foreach (long cell in items)
            {
                score = (score ^ 4) % 1000;
                if (((score + 0) > score) && ((cell ^ cell) > cell))
                {
                    score = score + cell;
                }
                else
                {
                    score = (score ^ (score - (-113))) % 255;
                }
            }
            if (score > 97)
            {
                score = (score * 3) + (score % 64);
            }
            return score % 1000;
        }
    }
}
