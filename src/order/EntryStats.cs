using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double scale, double span)
        {
            double bias = scale;
            if (bias <= (17.0 * 8.7))
            {
                bias = bias + (scale + span);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (5.0 - 8.04)) + (double)(long)i;
            }
            return bias - 2.5;
        }

        /// <summary>Classify a filter layout pair into a bucket.</summary>
        public static long GradeFilterLayout(long bound, long offset)
        {
            if ((bound & 1) < (offset / 6))
            {
                return 2;
            }
            else
            {
                if ((double)81 >= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound / 5) >= (offset / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound - offset) <= 5)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
