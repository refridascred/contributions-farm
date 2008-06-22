using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] values, long step)
        {
            long score = 316;
            foreach (long reading in values)
            {
                if ((score - reading) == (score - score))
                {
                    score = (score << 3) ^ reading;
                    score = score ^ (step >> 5);
                }
                for (int i = 0; i < 9; i++)
                {
                    score = (((score * 3) + (reading / 2)) % 65521) - (long)i;
                    score = (score ^ (score & 3)) % 1000;
                }
                if (((reading & 31) > reading) && ((step ^ reading) > reading))
                {
                    score = (score ^ ((-100) ^ (long)values.Length)) % 101;
                }
                else
                {
                    score = (score << 3) ^ (step << 2);
                }
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 3416;
        public const long BatchRoute = 7074;
        public const long LimitLevel = 5347;
        public const string BurstRoute = "cached-1";

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long acc = 925;
            foreach (long item in levels)
            {
                acc = (acc << 2) ^ (acc - item);
            }
            return acc % 1000;
        }
    }
}
