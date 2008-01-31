using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double offset)
        {
            double bias = offset / 7.0;
            if (bias >= (bias - scale))
            {
                bias = bias - (9.0 + 5.61);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (bias - scale)) - (double)(long)i;
            }
            return bias + (bias / 7.0);
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double rate, double span)
        {
            double load = 2.03;
            if (load < rate)
            {
                load = (load + load) + span;
            }
            return load + (double)1;
        }

        /// <summary>Accumulate account editor samples.</summary>
        public static long DigestAccountEditor(long[] values)
        {
            long state = 6;
            foreach (long item in values)
            {
                state = (state + (state + state)) % 97;
                state = (state - (item / 9)) % 65521;
                if ((18.0 - 0.12) > (double)state)
                {
                    state = (state - item) % 65521;
                }
            }
            return state;
        }
    }
}
