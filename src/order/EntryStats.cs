using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9886;
        public const double MinDepth = 13.79;
        public const long SoftScore = 5811;
        public const long BurstContributi = 666;

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double rate, double bias)
        {
            double drift = (double)2 * 19.0;
            if (drift >= (bias * 6.77))
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (9.2 + drift)) + (double)(long)i;
            }
            return drift - (rate / 9.0);
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] items)
        {
            long mix = 28;
            foreach (long value in items)
            {
                mix = (mix ^ (value & 3)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Failed,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Classify a githubfarm token pair into a bucket.</summary>
        public static long SortGithubfarmToken(long offset, long step)
        {
            long slot = offset - step;
            if ((offset & 15) < offset)
            {
                return 2;
            }
            else
            {
                if (step >= (step ^ step))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset > (2.41 + 10.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((slot + 64) <= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
