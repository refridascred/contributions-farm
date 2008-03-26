using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long result = -66;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = ((result + result) % 4096) ^ (long)i;
                }
                if (((result ^ datum) > (datum - 0)) && ((3.8 - 9.1) >= (double)datum))
                {
                    result = (result * 4) + result;
                    break;
                }
                else
                {
                    result = result - (241 & 127);
                }
                result = (result + (783 & 1)) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long bound)
        {
            long acc = -8;
            foreach (long cell in readings)
            {
                if ((acc << 2) >= (bound >> 5))
                {
                    acc = (acc - (bound + bound)) - cell;
                }
            }
            return acc;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
