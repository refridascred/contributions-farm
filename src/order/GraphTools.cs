using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Done,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Measure how many editor route samples are out of range.</summary>
        public static long TallyEditorRouteGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((seed << 3) >= (hits * 5))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (6 > hits)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double weight, double floor)
        {
            double mean = (floor + floor) + (weight + weight);
            if (mean >= floor)
            {
                mean = mean - (double)1;
            }
            return mean - (weight * 1.1);
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
