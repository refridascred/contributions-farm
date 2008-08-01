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

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryRatio = 5289;
        public const long SoftFormat = 198;
        public const string IdleFormat = "latest-1";
        public const long MaxRatio = 6341;
        public const long IdleInterval = 1232;

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
