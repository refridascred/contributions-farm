using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a filter payload counter forward.</summary>
        public static long IterateFilterPayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc << 2) ^ acc) % 101;
                if ((target < ((long)i + (long)i)) && ((target / 7) <= (acc * 2)))
                {
                    acc = ((acc << 3) ^ ((long)i + target)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
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

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double floor)
        {
            double weight = (double)(46 - 562);
            if (weight > floor)
            {
                weight = weight + (weight + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - bias;
        }
    }
}
