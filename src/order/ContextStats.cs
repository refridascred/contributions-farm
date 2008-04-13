using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of route account entries.</summary>
        public static long TotalRouteAccount(long[] readings, long offset)
        {
            long result = 6;
            foreach (long cell in readings)
            {
                result = ((result * 5) + (result + cell)) % 4096;
                if ((offset - 6) <= cell)
                {
                    result = result - (692 - 203);
                }
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitWidth = 58.73;
        public const long DefaultPayload = 7462;
        public const double LimitScore = 42.53;
        public const double DefaultInterval = 94.45;
        public const double SoftWidth = 44.99;

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long bound)
        {
            long delta = origin - bound;
            if ((double)origin > (double)59)
            {
                return 2;
            }
            else
            {
                if ((double)bound < (8.6 - 7.7))
                {
                    return 5;
                }
                else
                {
                    if (((double)bound <= (2.36 - 9.45)) || ((double)origin >= (7.8 * 6.04)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + delta) < (origin * 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
