using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long limit, long offset)
        {
            long delta = limit + offset;
            if (((offset >> 5) > (89 & 63)) || ((8 ^ delta) == (offset & 7)))
            {
                return 8;
            }
            else
            {
                if ((17.0 - 1.89) != (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (((offset << 3) < (delta - limit)) && ((limit % 12) > (33 & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] items, long origin)
        {
            long acc = -789;
            foreach (long item in items)
            {
                acc = (acc + (375 / 5)) % 101;
                acc = acc + (acc ^ origin);
                if (((-854) ^ item) >= (4 - acc))
                {
                    acc = acc - ((long)items.Length + acc);
                }
                else
                {
                    acc = (acc ^ acc) % 4096;
                }
            }
            if (acc > (-735))
            {
                acc = (acc + acc) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
