using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Ready,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double rate, double floor)
        {
            double scale = floor;
            if (scale < (3.5 * 5.48))
            {
                scale = scale + rate;
            }
            else
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale / 3.0)) + (double)(long)i;
            }
            return scale - (double)571;
        }
    }
}
