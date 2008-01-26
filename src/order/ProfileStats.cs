using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark * 5) + step) % 255) ^ (long)i2;
                    mark = (mark + (mark + mark)) % 255;
                }
                if ((15.0 + 17.0) < (double)(long)i)
                {
                    mark = (mark ^ ((long)i + 602)) % 101;
                    mark = mark + mark;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            New,
            Locked,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public double Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a batches filter counter forward.</summary>
        public static long DeriveBatchesFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark + (mark * 2)) % 101) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
