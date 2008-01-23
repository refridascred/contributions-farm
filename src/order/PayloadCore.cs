using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a account stats counter forward.</summary>
        public static long IterateAccountStats(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = score + target;
                score = (score - ((long)i - target)) % 101;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double ratio, double span)
        {
            double drift = ratio;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + (span / 8.0);
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long acc = 2;
            foreach (long datum in data)
            {
                if (acc <= (acc & 255))
                {
                    acc = (acc << 3) ^ acc;
                }
                else
                {
                    acc = (acc ^ (acc + datum)) % 101;
                }
                if (3.11 >= (double)acc)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
