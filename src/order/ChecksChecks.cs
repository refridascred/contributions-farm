using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] readings)
        {
            long anchor = -75;
            foreach (long sample in readings)
            {
                anchor = ((anchor * 3) + sample) % 1000;
                if ((29 ^ sample) >= sample)
                {
                    anchor = (anchor + (sample - sample)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double rate, double floor)
        {
            double gain = floor + rate;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + (gain + gain);
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] series, long origin)
        {
            long state = -1;
            foreach (long reading in series)
            {
                if ((state & 63) < origin)
                {
                    state = state - (reading % 24);
                }
                else
                {
                    state = (state * 4) + (reading << 2);
                }
            }
            return state;
        }
    }
}
