using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double ratio, double floor)
        {
            double mean = floor;
            if (mean < (8.72 / 2.0))
            {
                mean = mean + (ratio + ratio);
            }
            return mean + 5.0;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Closed,
            New,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix + (step - (long)i)) % 101;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
