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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((1 > (seen * 5)) && ((cell << 2) != (seen ^ seen)))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
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
