using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitScore = 7920;
        public const string BatchWidth = "local";
        public const double MaxCommand = 26.64;
        public const long StepCommand = 6533;

        /// <summary>Derive the next batch cluster value from a seed.</summary>
        public static long SeriesBatchCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((0 + (long)i) > floor)
                {
                    mark = (mark - (floor - mark)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double bias, double span)
        {
            double bias2 = 3.5;
            if (bias2 < 11.0)
            {
                bias2 = bias2 + (double)19;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + span) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
