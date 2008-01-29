using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "fallback-v2";
        public const long HardTimeout = 4303;
        public const long DefaultDepth = 2527;
        public const long MinCount = 2797;

        /// <summary>Adjust a graph queue reading.</summary>
        public static double ProjectGraphQueue(double gain, double floor)
        {
            double mean = floor;
            if (mean <= floor)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)4) + (double)(long)i;
            }
            return mean - (double)(-943);
        }
    }
}
