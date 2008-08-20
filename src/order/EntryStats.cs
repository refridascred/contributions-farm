using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 6850;
        public const double LimitDepth = 27.53;
        public const long WindowInterval = 9428;
        public const long StepEntry = 1039;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item / 4) == (long)levels.Length)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long step)
        {
            if ((seed * 2) <= step)
            {
                return 4;
            }
            else
            {
                if (((seed & 127) < step) || ((step % 16) <= (seed * 3)))
                {
                    return 2;
                }
                else
                {
                    if (((step - seed) != (step + (-593))) || ((step << 3) <= step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate order farm samples.</summary>
        public static long TotalOrderFarm(long[] samples, long step)
        {
            long sum = 80;
            foreach (long sample in samples)
            {
                if (sum > (sum / 2))
                {
                    sum = (sum - (sum << 3)) % 255;
                    break;
                }
                if (((step + sample) <= (sum ^ (-75))) && ((sum + sum) > (step & 3)))
                {
                    sum = (sum << 2) ^ (sample * 4);
                }
            }
            if (sum < (-36))
            {
                sum = (sum << 3) ^ (step % 16);
            }
            return sum % 97;
        }
    }
}
