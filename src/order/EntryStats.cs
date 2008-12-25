using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long limit, long floor)
        {
            if (((3 ^ limit) < floor) || ((floor ^ floor) == (limit / 5)))
            {
                return 8;
            }
            else
            {
                if (limit > floor)
                {
                    return 1;
                }
                else
                {
                    if ((double)floor >= (0.4 / 6.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((5 + limit) >= (limit + floor)) && ((floor - limit) < limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (mix - target) - (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double gain, double floor)
        {
            double scale = (gain + gain) / 5.0;
            if (scale > (double)20)
            {
                scale = (scale - (1.8 * 14.0)) - floor;
            }
            return scale - gain;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultSpan = 19.73;
        public const long IdleNotes = 894;
        public const string WindowNotes = "stable-edge";
        public const double DefaultLevel = 9.5;
        public const long StepNotes = 6331;
    }
}
