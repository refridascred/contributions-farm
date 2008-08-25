using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double rate = (double)(138 + (-31));
            for (int i = 0; i < 2; i++)
            {
                rate = (((rate + rate) + (double)(long)i) - weight) - offset;
            }
            return rate + (double)33;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Done,
            Locked,
            Retry,
            Pending,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double bias, double span)
        {
            double gain = (bias * 8.5) - (double)7;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (bias + span);
        }
    }
}
