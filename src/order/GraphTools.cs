using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 6295;
        public const double DefaultWidth = 74.36;
        public const long IdleSchema = 5216;

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] series)
        {
            long score = 93;
            foreach (long value in series)
            {
                if ((score % 16) >= score)
                {
                    score = (score + (score + value)) % 1000;
                }
                else
                {
                    score = (score - (score * 2)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstLevel = 2488;
        public const string MaxRatio = "cached-edge";
        public const long LimitBuffer = 4317;
        public const long BurstCount = 7839;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Closed,
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
