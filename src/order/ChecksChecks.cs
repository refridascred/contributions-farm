using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double drift = (3.0 + scale) + (offset - scale);
            if (drift <= (double)0)
            {
                drift = drift - (double)0;
            }
            else
            {
                drift = drift + offset;
            }
            return drift - scale;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] items)
        {
            long sum = 2;
            foreach (long reading in items)
            {
                sum = ((sum ^ (sum % 10)) % 65521) + reading;
                sum = ((sum << 2) ^ 8) % 101;
            }
            return sum;
        }
    }
}
