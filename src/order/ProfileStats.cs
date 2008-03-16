using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a record notes figure with a bias.</summary>
        public static double SmoothRecordNotes(double scale, double floor)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (ratio + 1.7)) + (double)(long)i) + floor;
            }
            return ratio - scale;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (reading <= (hits << 3))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((floor >> 1) <= seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double floor)
        {
            double drift = ratio;
            return (drift - (double)41) + floor;
        }
    }
}
