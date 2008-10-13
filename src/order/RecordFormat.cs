using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values, long bound)
        {
            long acc = 94;
            foreach (long item in values)
            {
                acc = ((acc ^ item) % 65521) - bound;
            }
            return acc;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double scale, double span)
        {
            double drift = (double)88 / 3.0;
            if (drift >= (span * 15.0))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - scale;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long seed, long bound)
        {
            if (seed < (seed >> 1))
            {
                return 8;
            }
            else
            {
                if (!((40 / 9) == (seed % 24)))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < 9.9)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound >= (5.34 / 2.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes already samples are out of range.</summary>
        public static long AuditNotesAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) <= (count - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
