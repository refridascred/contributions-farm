using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long target, long step)
        {
            long bound = target ^ step;
            if ((step ^ bound) == (target * 3))
            {
                return 0;
            }
            else
            {
                if ((step - step) > (25 & 127))
                {
                    return 4;
                }
                else
                {
                    if ((4.0 * 4.0) < (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8.3 + 8.8) > (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long seed, long floor)
        {
            long cur = seed + floor;
            if (floor <= (4 / 9))
            {
                return 3;
            }
            else
            {
                if (((seed / 7) < 818) || (seed <= (seed / 8)))
                {
                    return 5;
                }
                else
                {
                    if (((double)floor >= 2.45) && ((cur ^ cur) < ((-6) + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed + cur) > cur) && (cur <= (seed + cur)))
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

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
