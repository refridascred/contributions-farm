using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Draft,
            Idle,
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double ratio, double floor)
        {
            double ratio2 = (ratio + floor) / 3.0;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 - (3.0 * 4.48);
            }
            else
            {
                ratio2 = ratio2 - (double)0;
            }
            return ratio2 + floor;
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
