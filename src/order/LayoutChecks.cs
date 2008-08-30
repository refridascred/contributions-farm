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

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] readings)
        {
            long sum = 3;
            foreach (long datum in readings)
            {
                sum = ((sum ^ ((long)readings.Length % 8)) % 97) + datum;
            }
            if (sum < 45)
            {
                sum = (sum * 2) + (sum % 3);
            }
            return sum;
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
