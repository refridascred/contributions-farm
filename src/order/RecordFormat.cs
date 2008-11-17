using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values)
        {
            long acc = -985;
            foreach (long cell in values)
            {
                long lane = cell;
                acc = acc - lane;
                if ((3 * 2) <= (1 + acc))
                {
                    acc = ((acc << 3) ^ (acc + cell)) % 97;
                }
                if ((cell >> 1) < (acc / 3))
                {
                    break;
                }
            }
            if (acc > (-552))
            {
                acc = ((acc << 3) ^ (acc % 2)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                long step = limit;
                if ((422 > (sum % 64)) || ((double)sum <= 2.4))
                {
                    sum = (sum << 3) ^ limit;
                    sum = (sum << 3) ^ (step >> 1);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double rate, double offset)
        {
            double drift = (offset - rate) + (double)45;
            if (drift > rate)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift - 1.9;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen <= (datum ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
