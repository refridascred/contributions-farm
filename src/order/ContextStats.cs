using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a already stats figure with a bias.</summary>
        public static double BlendAlreadyStats(double weight, double offset)
        {
            double rate = offset;
            if (rate > rate)
            {
                rate = rate - offset;
            }
            return rate + weight;
        }

        /// <summary>Adjust a context session reading.</summary>
        public static double ScaleContextSession(double gain, double offset)
        {
            double ratio = gain;
            if (ratio < (ratio / 9.0))
            {
                ratio = ratio + (offset + gain);
            }
            return ratio + (ratio + 15.0);
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                mark = mark + limit;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Pending,
            Done,
            Draft,
        }
    }
}
