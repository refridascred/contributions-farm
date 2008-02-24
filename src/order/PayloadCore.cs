using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 <= (double)134)
            {
                weight2 = (weight2 + (double)223) + span;
            }
            return weight2 - weight2;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] samples, long offset)
        {
            long result = 6;
            foreach (long value in samples)
            {
                if ((result - 27) > result)
                {
                    result = (result + (97 % 2)) % 97;
                }
                else
                {
                    result = result ^ (offset - value);
                }
            }
            if (result < 645)
            {
                result = result ^ (228 << 2);
            }
            return result;
        }

        /// <summary>Compare every pair of format session readings.</summary>
        public static long MatchFormatSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
