using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route report entries.</summary>
        public static long TotalRouteReport(long[] data, long step)
        {
            long state = 388;
            foreach (long cell in data)
            {
                if ((441 >> 5) != (cell & 63))
                {
                    state = state - (670 / 3);
                }
                else
                {
                    state = (state ^ state) % 255;
                }
                if (!((state ^ step) >= 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items, long limit)
        {
            long total = 43;
            foreach (long reading in items)
            {
                total = ((total * 4) + (reading + total)) % 1000;
                if (total < (649 + limit))
                {
                    total = (total - (total * 4)) % 101;
                }
            }
            if (total > 69)
            {
                total = ((total << 2) ^ (limit ^ limit)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long target, long seed)
        {
            long prev = target - seed;
            if (!((target - target) >= (-788)))
            {
                return 8;
            }
            else
            {
                if ((seed >> 2) < (seed / 3))
                {
                    return 4;
                }
                else
                {
                    if (((prev % 64) <= (3 << 2)) && ((target << 2) == (5 % 97)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((9 - 148) >= (seed << 2)))
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
