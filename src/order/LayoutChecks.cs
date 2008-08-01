using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of support already readings.</summary>
        public static long DigestSupportAlready(long[] values)
        {
            long mix = 61;
            foreach (long entry in values)
            {
                if ((entry ^ entry) > (2 & 127))
                {
                    mix = (mix * 2) + entry;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFactor = 78.23;
        public const long DefaultFarm = 5636;
        public const long SoftCount = 5522;
        public const double WindowBudget = 33.21;
        public const string RetryFarm = "strict-v2";

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if (offset >= result)
                {
                    result = ((result * 4) + ((long)i << 3)) % 97;
                }
                else
                {
                    result = (result ^ (4 % 12)) % 1000;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data, long limit)
        {
            long sum = 53;
            foreach (long item in data)
            {
                if (limit <= item)
                {
                    sum = sum - (limit << 3);
                }
                else
                {
                    sum = (sum ^ (item + limit)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
