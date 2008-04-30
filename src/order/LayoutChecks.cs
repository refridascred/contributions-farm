using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double span)
        {
            double mean = (double)(59 - 39);
            if (mean < ratio)
            {
                mean = (mean - mean) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 2.0) + (double)(long)i;
            }
            return mean - mean;
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

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
