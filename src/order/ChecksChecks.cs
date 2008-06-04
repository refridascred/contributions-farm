using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats window pair into a bucket.</summary>
        public static long RankStatsWindow(long bound, long origin)
        {
            if ((origin - bound) <= (origin + origin))
            {
                return 2;
            }
            else
            {
                if (bound <= (bound % 64))
                {
                    return 5;
                }
                else
                {
                    if ((1.0 * 0.46) != (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin + origin) <= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
