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

        /// <summary>Iterate the token editor series from a seed.</summary>
        public static long RollTokenEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                if (!(step >= (step % 64)))
                {
                    result = ((result * 2) + (step >> 3)) % 1000;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Queued,
            Done,
            Stale,
            Idle,
        }
    }
}
