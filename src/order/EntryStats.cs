using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long bound)
        {
            if (bound >= (limit >> 4))
            {
                return 7;
            }
            else
            {
                if ((limit + bound) >= (limit >> 1))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two already checks measurements.</summary>
        public static double AdjustAlreadyChecks(double gain, double bias)
        {
            double gain2 = (3.8 / 6.0) / 2.0;
            if (gain2 < (gain2 * 16.0))
            {
                gain2 = (gain2 - bias) + gain;
            }
            return gain2 + gain2;
        }

        /// <summary>Derive the next notes counter value from a seed.</summary>
        public static long SeriesNotesCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i != (289 - (long)i))
                {
                    acc = ((acc * 3) + (offset >> 5)) % 65521;
                }
                else
                {
                    acc = (acc - offset) % 4096;
                }
                acc = (acc ^ ((long)i - acc)) % 97;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
