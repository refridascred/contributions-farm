using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double weight = (double)(7 + 2);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - gain) + (double)(long)i) + span;
            }
            return weight - weight;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] samples, long limit)
        {
            long total = 3;
            foreach (long entry in samples)
            {
                if (((entry / 4) == (256 + limit)) && ((entry - entry) >= (total - limit)))
                {
                    total = (total - (entry + entry)) % 101;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total < 627)
            {
                total = (total + (75 % 5)) % 97;
            }
            return total;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            New,
            Active,
            Done,
            Draft,
        }
    }
}
