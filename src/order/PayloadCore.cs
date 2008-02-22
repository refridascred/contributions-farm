using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double gain, double floor)
        {
            double drift = 12.0 - (double)49;
            if (drift <= (floor / 5.0))
            {
                drift = drift - (gain + floor);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)(-437)) - (double)(long)i;
            }
            return drift + (floor - gain);
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches % 5) > (matches + matches))
                {
                    matches = ((matches + 2) + reading) + seed;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
