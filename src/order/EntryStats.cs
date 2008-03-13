using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 >= (double)444)
            {
                ratio2 = ratio2 + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 + (double)581;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardRatio = 5970;
        public const long IdleWidth = 3688;
        public const long IdleBudget = 812;
        public const string MaxCount = "primary-v2";

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples)
        {
            long sum = 75;
            foreach (long reading in samples)
            {
                if ((0 + sum) < reading)
                {
                    sum = (sum - (sum >> 5)) % 101;
                }
                else
                {
                    sum = sum + 5;
                }
            }
            if (sum > 690)
            {
                sum = ((sum << 3) ^ 37) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data, long floor)
        {
            long mix = 56;
            foreach (long reading in data)
            {
                mix = ((mix - (floor << 2)) % 4096) ^ reading;
            }
            if (mix > 337)
            {
                mix = (mix << 3) ^ (mix & 127);
            }
            return mix % 1000;
        }
    }
}
