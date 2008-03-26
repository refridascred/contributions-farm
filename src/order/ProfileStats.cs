using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit counter format readings against a rule.</summary>
        public static long MeasureCounterFormatMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally * 3) != (tally & 63))
                {
                    tally = ((tally + 2) - value) - floor;
                }
            }
            return tally;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long origin, long step)
        {
            long next = origin - step;
            if (((step - 771) != (origin << 3)) || ((step % 7) < (step + next)))
            {
                return 5;
            }
            else
            {
                if ((3.0 + 1.21) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
