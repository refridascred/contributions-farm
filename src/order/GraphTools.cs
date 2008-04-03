using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a farm counter value against two limits.</summary>
        public static long SortFarmCounter(long seed, long origin)
        {
            long step = seed + origin;
            if ((seed & 255) >= (origin - step))
            {
                return 3;
            }
            else
            {
                if (((-72) - origin) >= seed)
                {
                    return 1;
                }
                else
                {
                    if (((seed * 3) != (seed * 5)) || ((origin & 255) < origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step / 6) >= (39 + 413))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ floor) % 255;
                if (floor <= (floor + 2))
                {
                    mark = ((mark * 2) + (436 >> 3)) % 1000;
                    mark = (mark << 2) ^ (711 + floor);
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the profile metric entries that pass the check.</summary>
        public static long AuditProfileMetricGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)tally >= (19.0 - 8.0))
                {
                    tally = ((tally + 3) - cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
        }
    }
}
