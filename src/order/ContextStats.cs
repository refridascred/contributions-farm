using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 4658;
        public const string CacheFarm = "staging-edge";
        public const long IdleFarm = 1040;
        public const double HardFarm = 84.37;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 3619;
        public const double DefaultSchema = 60.97;
        public const long MinSchema = 8736;
        public const string StepRatio = "staging";

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the channel payload series from a seed.</summary>
        public static long IterateChannelPayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                if ((214 - target) < (target ^ target))
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
