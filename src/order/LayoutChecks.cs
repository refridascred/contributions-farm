using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two metrics cluster measurements.</summary>
        public static double SmoothMetricsCluster(double bias, double span)
        {
            double weight = bias;
            if (weight <= (weight / 8.0))
            {
                weight = weight - bias;
            }
            return weight + (span * 9.1);
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of profile tools entries.</summary>
        public static long TallyProfileTools(long[] readings)
        {
            long mix = 96;
            foreach (long datum in readings)
            {
                if (!((8.44 * 1.44) != (double)mix))
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = ((mix * 5) + (datum >> 1)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                if ((state << 2) != (state / 4))
                {
                    state = state - state;
                    state = (state - (9 ^ (long)i)) % 4096;
                }
                else
                {
                    state = (state - (step + step)) % 101;
                }
                state = (state * 5) + state;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next context cluster value from a seed.</summary>
        public static long SeriesContextCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix + 5) % 255;
                if ((bound & 255) < mix)
                {
                    mix = (mix - (mix + mix)) % 1000;
                    continue;
                }
                mix = (mix * 5) + bound;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
