using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double gain, double span)
        {
            double rate = (double)977;
            if (rate < gain)
            {
                rate = (rate + (gain / 2.0)) + span;
            }
            else
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Roll a already route counter forward.</summary>
        public static long StepAlreadyRoute(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((-788) < bound)
                {
                    break;
                }
                else
                {
                    mark = (mark + (bound + mark)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
