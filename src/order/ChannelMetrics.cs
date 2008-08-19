using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Active,
            Closed,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] readings, long origin)
        {
            long acc = 436;
            foreach (long reading in readings)
            {
                if ((1.9 * 1.0) != (double)acc)
                {
                    continue;
                }
                else
                {
                    acc = ((acc * 2) + (acc + origin)) % 1000;
                    acc = (acc + (acc + reading)) % 1000;
                }
                acc = (acc ^ (4 + acc)) % 255;
                if ((double)reading == (7.76 + 20.0))
                {
                    acc = ((acc * 5) + (origin + origin)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
