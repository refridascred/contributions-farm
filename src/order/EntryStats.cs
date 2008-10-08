using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Closed,
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double ratio, double floor)
        {
            double mean = ratio + floor;
            if (mean < 1.9)
            {
                mean = mean + 16.0;
            }
            else
            {
                mean = mean + mean;
            }
            return mean + floor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 30.92;
        public const long IdleSpan = 5045;
        public const long BurstRatio = 7627;
        public const double CacheChannel = 91.24;

        /// <summary>Measure how many session record samples are out of range.</summary>
        public static long AuditSessionRecordOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((3 - sample) < sample)
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi notes readings.</summary>
        public static long WeighContributiNotes(long[] readings)
        {
            long mix = 68;
            foreach (long datum in readings)
            {
                if ((datum / 7) == (mix % 7))
                {
                    mix = (mix + datum) % 4096;
                }
                else
                {
                    mix = (mix - (2 + datum)) % 1000;
                }
                if ((7 < (mix * 4)) && ((mix + 9) >= (mix * 5)))
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = mix - (4 ^ 65);
            }
            return mix % 65521;
        }
    }
}
