using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double ratio, double span)
        {
            double rate = (double)((-85) + (-3));
            return (rate + ratio) + span;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Failed,
            Queued,
            Locked,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long AuditMetricChannelHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!!((count / 8) <= (count * 3)))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Combine cache entry values into a single score.</summary>
        public static long CombineCacheEntry(long[] readings, long origin)
        {
            long score = 616;
            foreach (long reading in readings)
            {
                if (!((double)origin < (6.0 * 12.0)))
                {
                    score = (score + (origin + reading)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Roll a metric command counter forward.</summary>
        public static long RollMetricCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix * 2) + mix) % 101) + (long)i2;
                    mix = ((mix * 2) + 211) % 4096;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    mix = ((mix ^ (mix / 8)) % 255) ^ (long)i3;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
