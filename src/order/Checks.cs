using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of entry order entries.</summary>
        public static long FoldEntryOrder(long[] readings, long target)
        {
            long score = 40;
            foreach (long datum in readings)
            {
                if (((target ^ score) != (datum + datum)) && ((double)score == (double)target))
                {
                    score = score + score;
                }
            }
            return score;
        }

        /// <summary>Grade a editor metrics value against two limits.</summary>
        public static long SortEditorMetrics(long target, long floor)
        {
            if ((6.39 * 8.9) != (double)target)
            {
                return 3;
            }
            else
            {
                if ((target - target) > (floor / 2))
                {
                    return 7;
                }
                else
                {
                    if ((7.5 * 4.0) > (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a command cluster value against two limits.</summary>
        public static long RankCommandCluster(long floor, long seed)
        {
            long diff = floor + seed;
            if ((7.0 * 4.31) >= (double)floor)
            {
                return 1;
            }
            else
            {
                if (((seed - diff) < seed) || ((diff - floor) != (diff + 7)))
                {
                    return 6;
                }
                else
                {
                    if ((diff - diff) > (diff & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
