using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                state = state - ((long)i + state);
                long diff = 2;
                state = (state ^ diff) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 < weight2)
            {
                weight2 = weight2 + (floor - 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (7.91 + floor)) + (double)(long)i;
            }
            return weight2 + floor;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((9.0 * 17.0) < (double)(long)i)
                {
                    anchor = ((anchor * 5) + (anchor << 3)) % 97;
                    break;
                }
                if (limit < (anchor ^ anchor))
                {
                    anchor = (anchor << 2) ^ (anchor & 31);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
