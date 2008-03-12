using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 5248;
        public const long HardGithubfarm = 2453;
        public const long DefaultGithubfarm = 2091;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
