using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowScore = "strict-edge";
        public const double MaxContext = 45.08;
        public const double StepContext = 32.3;
        public const long BurstContext = 5273;
        public const long IdleScore = 933;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Grade a account notes value against two limits.</summary>
        public static long GradeAccountNotes(long offset, long origin)
        {
            if ((6 % 5) != (origin + (-478)))
            {
                return 1;
            }
            else
            {
                if (!(offset > (origin / 5)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Idle,
            Active,
            New,
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
