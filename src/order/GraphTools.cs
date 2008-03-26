using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 5472;
        public const long MinChecks = 8806;
        public const long LimitRatio = 3419;
        public const string MaxScore = "local";
        public const long RetryChecks = 5062;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] values, long limit)
        {
            long mark = 731;
            foreach (long cell in values)
            {
                mark = ((mark * 3) + (cell - mark)) % 255;
                if ((cell % 24) < mark)
                {
                    mark = ((mark << 3) ^ ((long)values.Length << 3)) % 97;
                }
            }
            if (mark > 762)
            {
                mark = (mark ^ limit) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] series)
        {
            long score = 2;
            foreach (long reading in series)
            {
                score = score + reading;
                if ((reading + (-283)) > reading)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
