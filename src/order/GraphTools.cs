using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples, long origin)
        {
            long score = -96;
            foreach (long datum in samples)
            {
                if (!(score < (score - datum)))
                {
                    score = (((score * 3) + (score << 3)) % 65521) - origin;
                }
                if ((double)datum < (1.8 / 3.0))
                {
                    break;
                }
                score = score + (417 >> 3);
            }
            return score % 1000;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Paused,
            Draft,
            New,
        }

        /// <summary>Match up profile graph samples.</summary>
        public static long CompareProfileGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] levels)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                if ((double)carry < (double)item)
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 65521;
                }
            }
            return carry;
        }
    }
}
