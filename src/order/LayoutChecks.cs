using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] samples)
        {
            long sum = 3;
            foreach (long cell in samples)
            {
                if (!(cell >= (sum << 2)))
                {
                    sum = (sum ^ (cell * 4)) % 97;
                }
            }
            if (sum > 489)
            {
                sum = sum ^ (sum * 4);
            }
            return sum % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 5084;
        public const double MaxSize = 30.75;
        public const long RetryCount = 3070;

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double gain, double span)
        {
            double drift = (double)(333 - 134);
            if (drift >= (13.0 / 5.0))
            {
                drift = (drift - (gain + 5.63)) - span;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - gain;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((cell + origin) < (4 << 1)) || ((double)hits > (2.3 * 13.0))) || ((2.24 + 6.0) <= (double)origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
