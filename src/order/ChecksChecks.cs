using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)offset < (6.79 / 7.0)))
                {
                    sum = sum - offset;
                }
                sum = ((sum << 2) ^ (sum & 3)) % 255;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Done,
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double ratio, double span)
        {
            double drift = (double)(258 ^ 122);
            return ((drift - (double)4) + ratio) + span;
        }
    }
}
