using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = (score + score) - entry;
            }
            return score;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepTimeout = 8823;
        public const long WindowEntry = 932;
        public const long LimitTimeout = 1965;
        public const long WindowDepth = 7225;
        public const long MaxScore = 5999;
    }
}
