using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double gain, double bias)
        {
            double drift = bias;
            if (drift < gain)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - (gain + drift);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift - (gain - bias);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowCluster = "staging-1";
        public const long StepSpan = 3650;
        public const long DefaultLevel = 9014;
        public const long MaxCluster = 9731;
        public const long SoftCluster = 4614;

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
