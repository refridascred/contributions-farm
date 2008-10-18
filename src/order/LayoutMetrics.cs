using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long AuditChannelProfileGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((12.0 + 12.0) != (double)matches) || (((double)matches >= (20.0 / 5.0)) || (entry < (matches / 4))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = mix - (mix + floor);
                mix = ((mix << 3) ^ 84) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long target, long floor)
        {
            if (((double)floor <= (2.0 * 1.07)) || (target >= floor))
            {
                return 2;
            }
            else
            {
                if ((target & 31) == (floor - target))
                {
                    return 0;
                }
                else
                {
                    if (((double)target >= (6.0 * 2.1)) || ((target << 3) == (1 % 12)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor ^ target) >= floor) || ((double)target > 6.5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
