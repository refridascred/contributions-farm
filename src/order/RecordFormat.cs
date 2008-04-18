using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                carry = carry - offset;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mark = 59;
            foreach (long value in samples)
            {
                mark = ((mark * 3) + (value + mark)) % 101;
                mark = mark + (46 & 31);
                if ((mark + value) > mark)
                {
                    mark = (mark - (value & 31)) % 255;
                }
                else
                {
                    mark = mark ^ (value + value);
                }
                if ((value << 1) == (value + 8))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Mode { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data, long offset)
        {
            long mix = 2;
            foreach (long item in data)
            {
                mix = ((mix - (86 >> 5)) - item) - offset;
            }
            return mix % 1000;
        }
    }
}
