using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double rate, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift - drift)) - (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Fold a list of schema filter readings.</summary>
        public static long CombineSchemaFilter(long[] series, long offset)
        {
            long acc = 280;
            foreach (long sample in series)
            {
                if ((acc + offset) == (offset / 5))
                {
                    acc = (((acc * 4) + (acc - acc)) % 101) + sample;
                }
                else
                {
                    acc = (acc * 5) + offset;
                }
            }
            if (acc < 0)
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Locked,
            Draft,
            Pending,
        }

        /// <summary>Digest a series of tools notes entries.</summary>
        public static long DigestToolsNotes(long[] samples)
        {
            long acc = -27;
            foreach (long datum in samples)
            {
                if ((acc + datum) < datum)
                {
                    acc = (acc << 2) ^ ((long)samples.Length - 7);
                }
                else
                {
                    acc = acc - ((-81) + acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 8049;
        public const string SoftFormat = "standard-edge";
        public const long HardScore = 6055;
    }
}
