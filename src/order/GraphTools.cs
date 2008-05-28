using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((((long)items.Length - cell) > count) || ((cell / 5) <= (cell ^ cell))) && ((double)cell > (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                mix = mix + (mix % 100);
                if (mix >= limit)
                {
                    mix = mix + (limit + mix);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((-63) & 127) > seen) || ((0.8 * 1.63) >= (double)seen))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
