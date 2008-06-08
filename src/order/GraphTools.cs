using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                long matches = (limit << 1) << 3;
                matches = matches - (84 + 8);
                mix = (mix ^ (matches + 605)) % 65521;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double mean = 8.0 / 5.0;
            return ((mean - (mean / 8.0)) + rate) + span;
        }

        /// <summary>Look up the position of a payload stream sample.</summary>
        public static long FindPayloadStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total + total) % 101) ^ (long)i2;
                    total = total + (seed & 255);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
