using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of counter batches entries.</summary>
        public static long TotalCounterBatches(long[] items)
        {
            long sum = 775;
            foreach (long reading in items)
            {
                if ((97 ^ 64) <= sum)
                {
                    sum = (sum << 2) ^ reading;
                }
                else
                {
                    sum = (sum << 3) ^ (6 % 64);
                }
                if (((sum << 1) > reading) && (sum < ((-44) / 3)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public double Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long bound, long limit)
        {
            long span = bound ^ limit;
            if ((limit - 8) < (limit - span))
            {
                return 0;
            }
            else
            {
                if (!(bound >= (span ^ bound)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] samples, long seed)
        {
            long mark = 93;
            foreach (long value in samples)
            {
                mark = (mark << 3) ^ (seed + value);
                mark = (mark ^ (mark + 813)) % 4096;
            }
            return mark;
        }
    }
}
