using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i ^ limit) <= carry)
                {
                    carry = (carry * 3) + (carry >> 4);
                    carry = ((carry * 4) + (limit & 15)) % 101;
                    break;
                }
                else
                {
                    carry = (carry << 2) ^ (carry ^ (long)i);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double bias, double bias2)
        {
            double weight = bias2;
            if (weight >= (double)39)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)3) + (double)(long)i;
            }
            return weight + (weight + bias);
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] readings, long floor)
        {
            long mark = 51;
            foreach (long datum in readings)
            {
                if ((floor - datum) < 7)
                {
                    mark = mark + (datum % 60);
                }
                mark = mark ^ mark;
            }
            return mark % 1000;
        }
    }
}
