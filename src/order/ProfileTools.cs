using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            New,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 4573;
        public const long BatchFactor = 5151;
        public const long MinBatch = 4188;
        public const double HardLevel = 66.02;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count already cluster pairs that satisfy a relation.</summary>
        public static long PairAlreadyClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
