using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a graph queue counter forward.</summary>
        public static long RollGraphQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((0.75 / 9.0) == (double)floor)
                {
                    acc = acc + (floor + acc);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long target, long seed)
        {
            if (!((double)seed > (0.94 + 12.0)))
            {
                return 1;
            }
            else
            {
                if (((target + seed) < (seed / 5)) && (target > (seed + 77)))
                {
                    return 8;
                }
                else
                {
                    if (((seed + target) == (target << 1)) || ((6.9 / 4.0) >= (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-429) <= (seed - 8)) || ((10.0 + 1.84) < (double)seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cache format entries that pass the check.</summary>
        public static long MeasureCacheFormatHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((347 - datum) > (datum + (-553)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
