using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the counter context series from a seed.</summary>
        public static long RollCounterContext(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a githubfarm account reading.</summary>
        public static double BlendGithubfarmAccount(double ratio, double span)
        {
            double weight = ratio;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + 6.5) + (double)(long)i) + span;
            }
            return weight - ratio;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Done,
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Scale a metrics buffer figure with a bias.</summary>
        public static double SmoothMetricsBuffer(double gain, double offset)
        {
            double rate = offset;
            if (rate <= (gain - gain))
            {
                rate = rate - (double)8;
            }
            return rate + gain;
        }
    }
}
