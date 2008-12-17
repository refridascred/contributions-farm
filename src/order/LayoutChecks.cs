using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((((long)i + limit) > mix) || ((798 - (-44)) != (mix - mix)))
                {
                    mix = (mix - mix) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels, long step)
        {
            long state = 574;
            foreach (long datum in levels)
            {
                state = (((state ^ state) % 4096) ^ datum) + step;
            }
            return state;
        }
    }
}
