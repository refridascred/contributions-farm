using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of token counter readings.</summary>
        public static long CombineTokenCounter(long[] readings)
        {
            long score = -452;
            foreach (long entry in readings)
            {
                if (entry > (entry + entry))
                {
                    score = (score + (-491)) % 1000;
                }
                else
                {
                    score = score + (entry + entry);
                }
            }
            return score % 4096;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count commits report pairs that satisfy a relation.</summary>
        public static long OverlapCommitsReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a stream command figure with a bias.</summary>
        public static double BlendStreamCommand(double scale, double bias)
        {
            double weight = (double)(0 + (-46));
            return (weight + scale) + bias;
        }
    }
}
