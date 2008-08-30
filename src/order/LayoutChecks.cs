using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double rate, double floor)
        {
            double mean = floor;
            if (mean > (double)(-9))
            {
                mean = (mean - (floor + mean)) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 15.0) - (double)(long)i;
            }
            return mean + (double)94;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((56 > (target ^ entry)) || (((long)series.Length - hits) >= (entry / 6)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double ScaleNotesCluster(double gain, double floor)
        {
            double ratio = (floor / 3.0) * 19.0;
            return (ratio + (1.44 / 4.0)) + gain;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 5107;
        public const string BaseFactor = "local-v2";
        public const string LimitRatio = "standard-1";
    }
}
