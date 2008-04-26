using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Adjust a editor profile reading.</summary>
        public static double AdjustEditorProfile(double rate, double bias)
        {
            double rate2 = (rate + bias) - rate;
            if (rate2 >= (double)984)
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 - (5.95 - bias)) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum + (seed + sum)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
