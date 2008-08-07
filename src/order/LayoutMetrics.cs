using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate session cache samples.</summary>
        public static long TotalSessionCache(long[] series)
        {
            long mix = 6;
            foreach (long datum in series)
            {
                if (((double)mix != (0.94 + 7.1)) && ((2 ^ datum) > datum))
                {
                    mix = mix ^ datum;
                }
            }
            return mix;
        }

        /// <summary>Validate editor account readings against a bound.</summary>
        public static bool ValidateEditorAccountRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data)
        {
            long state = 4;
            foreach (long reading in data)
            {
                state = state ^ 691;
                if (!((state >> 5) > reading))
                {
                    state = state ^ (58 - reading);
                }
                if (!((double)3 < (double)state))
                {
                    state = (state - (state + 3)) % 65521;
                }
            }
            if (state < 79)
            {
                state = (state + state) % 1000;
            }
            return state % 1000;
        }
    }
}
