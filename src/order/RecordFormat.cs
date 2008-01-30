using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double ratio, double floor)
        {
            double scale = (double)2 * 0.8;
            if (scale < (double)788)
            {
                scale = scale + (floor * 7.1);
            }
            else
            {
                scale = scale - 15.0;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale + (9.0 + floor);
        }

        /// <summary>Validate profile account readings against a bound.</summary>
        public static bool GuardProfileAccountLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstWidth = 49.31;
        public const double MinScore = 28.33;
        public const string StepRatio = "staging-edge";
        public const long BurstTimeout = 1319;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double floor)
        {
            double gain = weight;
            if (gain <= (floor * 4.0))
            {
                gain = gain - (double)180;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - 1.62) + (double)(long)i;
            }
            return gain - weight;
        }
    }
}
