using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long bound, long bound2)
        {
            if ((bound + bound) < (bound / 9))
            {
                return 1;
            }
            else
            {
                if (((bound2 - bound) < (19 + bound2)) && ((double)bound >= (19.0 + 8.7)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long target, long offset)
        {
            long offset2 = target - offset;
            if ((target ^ offset2) == (offset2 - target))
            {
                return 5;
            }
            else
            {
                if (((offset2 + target) < 64) && (target >= (offset2 - target)))
                {
                    return 3;
                }
                else
                {
                    if (target >= (offset - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target - offset2) == (offset2 + offset2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc << 3) ^ (58 << 2)) % 255;
                acc = acc ^ (long)i;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a entry contributi sample.</summary>
        public static long SeekEntryContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
