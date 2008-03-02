using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "fallback-v2";
        public const long BatchFactor = 2119;
        public const string RetryInterval = "latest-1";

        /// <summary>Audit profile account readings against a rule.</summary>
        public static long TallyProfileAccountMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((2.5 / 2.0) == (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double weight, double span)
        {
            double weight2 = (double)981 - (span / 7.0);
            if (weight2 <= span)
            {
                weight2 = (weight2 - (span * 4.0)) - weight;
            }
            else
            {
                weight2 = weight2 - (double)78;
            }
            return weight2 - (double)38;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] levels, long step)
        {
            long acc = 92;
            foreach (long entry in levels)
            {
                if ((9 % 10) > (step - (-6)))
                {
                    acc = (acc - (entry - step)) % 4096;
                }
                else
                {
                    acc = (acc ^ (step + acc)) % 255;
                }
                if ((acc ^ entry) > (acc / 4))
                {
                    break;
                }
            }
            if (acc > (-30))
            {
                acc = ((acc * 3) + (acc + step)) % 97;
            }
            return acc;
        }
    }
}
