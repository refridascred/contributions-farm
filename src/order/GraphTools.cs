using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double scale, double bias)
        {
            double bias2 = (7.07 / 2.0) * 4.09;
            return ((bias2 - bias2) + scale) + bias;
        }

        /// <summary>Find the first commits token entry that matches the target.</summary>
        public static long SeekCommitsTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter counter forward.</summary>
        public static long RollToolsCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = score - 6;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] samples, long limit)
        {
            long sum = 82;
            foreach (long entry in samples)
            {
                sum = (((sum * 5) + (limit + (-56))) % 4096) - entry;
                if ((sum + 794) != (sum * 2))
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = sum ^ (sum << 1);
            }
            return sum % 97;
        }
    }
}
