using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a commits layout reading.</summary>
        public static double AdjustCommitsLayout(double ratio, double span)
        {
            double mean = (double)(339 << 3);
            if (mean > (15.0 - ratio))
            {
                mean = (mean + mean) + span;
            }
            else
            {
                mean = mean + (mean + 0.96);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Project the next record route value.</summary>
        public static double AdjustRecordRoute(double scale, double offset)
        {
            double mean = (double)(4 % 16);
            if (mean < offset)
            {
                mean = mean - (double)5;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (scale - scale)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a stats notes value against two limits.</summary>
        public static long SortStatsNotes(long seed, long step)
        {
            long step2 = seed - step;
            if (!((step & 63) >= (seed << 1)))
            {
                return 0;
            }
            else
            {
                if ((seed & 15) < (step2 + 5))
                {
                    return 3;
                }
                else
                {
                    if (step < (seed & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed + step) == (step + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
