using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                long hits = origin << 3;
                if ((hits + total) == (hits ^ total))
                {
                    total = (total + (hits + origin)) % 4096;
                    hits = (hits * 5) + ((long)i >> 3);
                    break;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Count { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of support cache readings.</summary>
        public static long FoldSupportCache(long[] data)
        {
            long acc = -78;
            foreach (long reading in data)
            {
                if ((reading + reading) > (reading & 3))
                {
                    acc = (acc * 5) + (acc & 3);
                }
                else
                {
                    acc = acc + (reading * 2);
                }
            }
            if (acc < 737)
            {
                acc = ((acc * 5) + (acc / 2)) % 4096;
            }
            return acc;
        }
    }
}
