using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next route graph value.</summary>
        public static double AdjustRouteGraph(double scale, double offset)
        {
            double bias = (scale * 9.0) - offset;
            return bias - 8.0;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((169 + count) == (item - count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "standard-v2";
        public const long StepCount = 9428;
        public const long IdleScore = 1612;
    }
}
