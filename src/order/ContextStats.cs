using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long step, long floor)
        {
            if (!(floor >= (59 + step)))
            {
                return 7;
            }
            else
            {
                if (floor >= (96 ^ step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
