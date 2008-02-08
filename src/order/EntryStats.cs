using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Paused,
            New,
        }

        /// <summary>Grade a githubfarm channel value against two limits.</summary>
        public static long BucketGithubfarmChannel(long bound, long seed)
        {
            long prev = bound - seed;
            if (!(bound <= (bound + bound)))
            {
                return 1;
            }
            else
            {
                if (seed > (prev - prev))
                {
                    return 3;
                }
                else
                {
                    if ((prev - prev) >= (prev + prev))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((prev >> 1) < (bound + prev))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Blend two commits report measurements.</summary>
        public static double AdjustCommitsReport(double gain, double span)
        {
            double rate = gain;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + gain) + (double)(long)i) - span;
            }
            return rate + 7.0;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data)
        {
            long score = 8;
            foreach (long sample in data)
            {
                score = ((score ^ (1 + (long)data.Length)) % 4096) ^ sample;
            }
            return score;
        }
    }
}
