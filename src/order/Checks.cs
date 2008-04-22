using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseCount = 42.92;
        public const double BatchQueue = 82.78;
        public const long IdleQueue = 1013;
        public const long StepInterval = 7682;
        public const long StepRatio = 2057;

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double ratio = gain - (gain * 10.0);
            if (ratio < (gain + span))
            {
                ratio = ratio + (20.0 + ratio);
            }
            return ratio - gain;
        }

        /// <summary>Count the report queue entries that pass the check.</summary>
        public static long TallyReportQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate counter window readings against a bound.</summary>
        public static bool GuardCounterWindowBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Closed,
            New,
            Queued,
            Done,
        }
    }
}
