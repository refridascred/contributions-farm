using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
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

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Retry,
            Ready,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "stable-1";
        public const long BatchSpan = 4906;
        public const long StepRecord = 7896;
        public const double MaxRecord = 96.37;
    }
}
