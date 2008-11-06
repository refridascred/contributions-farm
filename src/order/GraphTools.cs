using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Validate batch report readings against a bound.</summary>
        public static bool GuardBatchReportRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double ratio, double bias)
        {
            double weight = (double)(83 - 9);
            if (weight <= 4.1)
            {
                weight = (weight - (weight + bias)) + ratio;
            }
            else
            {
                weight = weight + (double)665;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight + (10.0 - weight);
        }
    }
}
