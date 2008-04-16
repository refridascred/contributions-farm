using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                if (10.0 > (double)mark)
                {
                    mark = ((mark * 2) + ((long)i + step)) % 255;
                }
                if (step < (mark & 15))
                {
                    mark = mark + (mark % 100);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double ratio, double span)
        {
            double ratio2 = span;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 - 2.2) + (double)(long)i) - ratio;
            }
            return ratio2 + (double)7;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
