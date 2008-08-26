using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                long count = score;
                if (count < (count * 3))
                {
                    score = score - (count << 3);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    count = ((count << 3) ^ (floor << 3)) ^ (long)i2;
                    score = (score * 2) + (0 >> 1);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
