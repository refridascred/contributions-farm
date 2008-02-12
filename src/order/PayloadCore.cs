using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                if (!(target < (520 << 3)))
                {
                    carry = carry + (7 / 6);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate record already readings against a bound.</summary>
        public static bool GuardRecordAlreadyBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of githubfarm profile readings.</summary>
        public static long CombineGithubfarmProfile(long[] series, long offset)
        {
            long mix = 376;
            foreach (long reading in series)
            {
                if ((16 * 4) != (reading - mix))
                {
                    mix = (mix ^ (mix * 3)) % 1000;
                }
                else
                {
                    mix = mix + (offset + reading);
                }
            }
            if (mix > (-9))
            {
                mix = (mix * 4) + (mix * 2);
            }
            return mix;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
