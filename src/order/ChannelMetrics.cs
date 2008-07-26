using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next checks token value.</summary>
        public static double AdjustChecksToken(double bias, double span)
        {
            double weight = 15.0;
            if (weight >= (bias + weight))
            {
                weight = (weight - bias) - span;
            }
            return weight - bias;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Match up record already samples.</summary>
        public static long CompareRecordAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
