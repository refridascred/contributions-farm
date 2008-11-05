using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                state = (state * 3) + (-7);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first counter route entry that matches the target.</summary>
        public static long SeekCounterRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support token readings against a bound.</summary>
        public static bool VerifySupportTokenRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
