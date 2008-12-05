using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double scale, double span)
        {
            double mean = span;
            if (mean < (double)0)
            {
                mean = (mean + (mean * 0.7)) - scale;
            }
            else
            {
                mean = mean + (double)198;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - (mean / 3.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchDepth = 77.78;
        public const string WindowReport = "strict-edge";
        public const string RetryBudget = "local-edge";

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 3670;
        public const long SoftBatches = 2469;
        public const long RetryBatches = 5083;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum ^ sum) % 1000;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
