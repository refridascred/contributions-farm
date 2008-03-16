using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double scale, double offset)
        {
            double load = scale * 5.9;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + 8.6) + (double)(long)i) - offset;
            }
            return load + (double)24;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double weight, double bias)
        {
            double bias2 = weight * 9.3;
            if (bias2 >= (5.3 * 4.6))
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + weight) + (double)(long)i;
            }
            return bias2 + weight;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Region { get; set; }
            public double Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
