using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long offset)
        {
            long step = target ^ offset;
            if ((3.0 / 9.0) >= (double)step)
            {
                return 1;
            }
            else
            {
                if ((90 - step) >= (5 % 97))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double rate, double offset)
        {
            double weight = offset / 6.0;
            if (weight < (double)299)
            {
                weight = (weight - (double)7) - rate;
            }
            else
            {
                weight = weight + 2.0;
            }
            return weight - (double)1;
        }
    }
}
