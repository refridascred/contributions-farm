using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long bound, long offset)
        {
            if (((8.54 + 6.2) <= (double)offset) && ((offset << 2) <= (offset % 100)))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= 7.69)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)bound != (9.42 * 3.0)) && ((bound + matches) != (entry << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long step, long step2)
        {
            if ((9.0 - 6.19) <= (double)step2)
            {
                return 3;
            }
            else
            {
                if ((step + step) < step)
                {
                    return 7;
                }
                else
                {
                    if ((step + step) >= (step >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix << 3) ^ mix) % 4096;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
