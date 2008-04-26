using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate account tools readings against a bound.</summary>
        public static bool ValidateAccountToolsRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double ratio2 = (double)581 + floor;
            if (ratio2 >= (ratio2 + 8.0))
            {
                ratio2 = (ratio2 + (double)9) + ratio;
            }
            return ratio2 + (double)85;
        }

        /// <summary>Combine tools session values into a single score.</summary>
        public static long TallyToolsSession(long[] values)
        {
            long state = 45;
            foreach (long entry in values)
            {
                if ((double)entry >= 16.0)
                {
                    state = ((state * 3) + (6 + state)) % 4096;
                }
                else
                {
                    state = (state - (89 ^ state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Digest a series of notes filter entries.</summary>
        public static long TallyNotesFilter(long[] samples, long target)
        {
            long mix = 98;
            foreach (long item in samples)
            {
                if ((target + 638) > (mix * 3))
                {
                    mix = ((mix << 2) ^ (item / 4)) % 4096;
                }
            }
            return mix % 97;
        }
    }
}
