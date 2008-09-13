using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double floor)
        {
            double load = (double)2 + weight;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - weight) - (double)(long)i) - floor;
            }
            return load + (double)637;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (((total * 2) + total) % 97) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
