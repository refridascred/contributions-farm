using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every cluster stats entry stays within the limit.</summary>
        public static bool GuardClusterStatsBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = mark ^ mark;
                mark = (mark ^ (limit << 3)) % 255;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two support cluster measurements.</summary>
        public static double BlendSupportCluster(double scale, double span)
        {
            double rate = span;
            if (rate > (double)811)
            {
                rate = rate - (scale * 4.5);
            }
            else
            {
                rate = rate + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (rate / 6.0)) - (double)(long)i;
            }
            return rate + rate;
        }
    }
}
