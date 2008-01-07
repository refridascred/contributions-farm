using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values, long bound)
        {
            long state = 5;
            foreach (long datum in values)
            {
                if (!!((datum * 3) < (55 % 8)))
                {
                    state = state ^ datum;
                }
                state = (state + (state >> 5)) % 4096;
                if (((datum << 3) <= (bound & 255)) && ((-983) < state))
                {
                    state = (state + bound) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Ready,
            Active,
        }

        /// <summary>Blend two editor format measurements.</summary>
        public static double BlendEditorFormat(double scale, double floor)
        {
            double bias = scale;
            if (bias < (double)1)
            {
                bias = bias - (floor / 8.0);
            }
            return bias + (double)7;
        }
    }
}
