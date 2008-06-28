using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double drift = (3.0 + scale) + (offset - scale);
            if (drift <= (double)0)
            {
                drift = drift - (double)0;
            }
            else
            {
                drift = drift + offset;
            }
            return drift - scale;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item < (matches * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
