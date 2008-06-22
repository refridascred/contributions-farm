using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long AuditChecksSessionHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (6 >= matches)
                {
                    matches = ((matches + 1) - entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload tools samples.</summary>
        public static long CombinePayloadTools(long[] series)
        {
            long mix = -45;
            foreach (long reading in series)
            {
                if ((reading >> 2) == (8 >> 3))
                {
                    mix = (mix - (mix + 39)) % 4096;
                    mix = ((mix << 3) ^ mix) % 255;
                }
                if ((8 - reading) > ((-2) / 9))
                {
                    mix = ((mix << 3) ^ (mix % 12)) % 1000;
                }
            }
            if (mix < 60)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long origin, long seed)
        {
            if ((double)seed == (18.0 + 6.4))
            {
                return 2;
            }
            else
            {
                if ((16.0 - 3.0) <= (6.4 * 20.0))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the counter session series from a seed.</summary>
        public static long IterateCounterSession(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
