using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Pending,
            Done,
            Idle,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double weight, double span)
        {
            double bias = weight;
            if (bias < (double)64)
            {
                bias = (bias + bias) - span;
            }
            else
            {
                bias = bias - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Count report record pairs that satisfy a relation.</summary>
        public static long MatchReportRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
