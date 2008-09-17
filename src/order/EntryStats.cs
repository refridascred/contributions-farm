using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((datum + 4) < (993 - target)) || !(target > (datum >> 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double bias2 = 18.0;
            if (bias2 < bias2)
            {
                bias2 = (bias2 - (bias2 + bias2)) + gain;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 - bias2;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long step, long seed)
        {
            long delta = step + seed;
            if (step <= delta)
            {
                return 7;
            }
            else
            {
                if (((289 ^ step) >= (8 + delta)) && ((step / 3) > step))
                {
                    return 4;
                }
                else
                {
                    if (!((delta ^ seed) != (4 + (-37))))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((10.0 < (double)tally) && ((double)datum >= 0.7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
