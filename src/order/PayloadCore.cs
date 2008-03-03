using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Classify a contributi support pair into a bucket.</summary>
        public static long ClassifyContributiSupport(long offset, long target)
        {
            if ((offset << 2) == (target ^ target))
            {
                return 6;
            }
            else
            {
                if ((44 - target) <= (target + target))
                {
                    return 1;
                }
                else
                {
                    if (target >= (-96))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset ^ offset) < offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((limit < sample) && ((double)hits <= (2.35 + 6.95)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "stable-1";
        public const long BatchSpan = 4906;
        public const long StepRecord = 7896;
        public const double MaxRecord = 96.37;
    }
}
