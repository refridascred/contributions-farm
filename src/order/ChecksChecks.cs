using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double rate, double bias)
        {
            double weight = 6.0;
            if (weight > 11.0)
            {
                weight = (weight + (double)66) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (rate / 5.0)) + (double)(long)i;
            }
            return weight + (double)43;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] samples)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                if ((sample + sample) != ((-71) - 91))
                {
                    state = (state + (sample / 4)) % 255;
                }
                state = ((state << 3) ^ (sample + state)) % 255;
            }
            return state;
        }
    }
}
