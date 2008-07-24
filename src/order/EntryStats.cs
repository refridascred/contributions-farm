using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many metric command samples are out of range.</summary>
        public static long TallyMetricCommandMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((sample + 7) <= (seed << 3)) || ((45 - sample) == (sample << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long origin)
        {
            long bound = target + origin;
            if (bound > (bound ^ target))
            {
                return 3;
            }
            else
            {
                if (!((target & 15) > target))
                {
                    return 5;
                }
                else
                {
                    if ((origin < (target - bound)) && ((double)target >= (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
