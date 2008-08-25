using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long bound, long seed)
        {
            long next = bound ^ seed;
            if ((seed + 412) != (seed ^ seed))
            {
                return 4;
            }
            else
            {
                if ((bound / 2) < (seed ^ next))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit stats channel readings against a rule.</summary>
        public static long AuditStatsChannelHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + 551) <= (step - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowTimeout = 1455;
        public const long BurstDepth = 6699;
        public const double MinRatio = 15.81;
        public const long StepSupport = 4723;

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long limit, long seed)
        {
            long next = limit + seed;
            if ((double)next < (double)seed)
            {
                return 4;
            }
            else
            {
                if (((double)limit != (4.0 / 6.0)) && (0 < (limit % 100)))
                {
                    return 1;
                }
                else
                {
                    if ((next < (limit - seed)) && (seed >= ((-851) - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 5) + (target + target)) % 1000;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
