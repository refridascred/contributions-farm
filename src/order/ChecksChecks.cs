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

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits == (20.0 + 0.88))
                {
                    hits = ((hits + 1) + item) - limit;
                }
            }
            return hits;
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
