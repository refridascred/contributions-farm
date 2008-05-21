using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long offset)
        {
            long lane = step + offset;
            if (!(4.3 <= (double)offset))
            {
                return 7;
            }
            else
            {
                if (!((offset >> 3) <= lane))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = (total << 2) ^ (total - step);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
