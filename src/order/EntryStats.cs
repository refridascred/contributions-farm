using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Retry,
            Stale,
            New,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a account contributi reading.</summary>
        public static double SmoothAccountContributi(double weight, double bias)
        {
            double bias2 = bias + weight;
            if (bias2 <= bias)
            {
                bias2 = bias2 + (weight * 5.48);
            }
            else
            {
                bias2 = bias2 - 12.0;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public double Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
