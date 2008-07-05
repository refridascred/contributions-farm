using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data)
        {
            long acc = 8;
            foreach (long sample in data)
            {
                if (((2.0 / 9.0) <= (double)acc) && (acc < (sample << 1)))
                {
                    acc = (acc << 2) ^ sample;
                }
                else
                {
                    acc = (acc << 2) ^ (acc + 46);
                }
            }
            if (acc > 65)
            {
                acc = (acc << 2) ^ (acc & 255);
            }
            return acc;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Dropped,
            Closed,
        }
    }
}
