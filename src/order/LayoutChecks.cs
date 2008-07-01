using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long floor, long origin)
        {
            if ((origin * 2) > floor)
            {
                return 6;
            }
            else
            {
                if ((double)origin < (1.0 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if (9.9 > (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next context commits value.</summary>
        public static double AdjustContextCommits(double gain, double span)
        {
            double load = (double)(3 ^ 6);
            if (load > (double)747)
            {
                load = load + (load * 16.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (span * 16.0)) - (double)(long)i;
            }
            return load - (load + gain);
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] values, long offset)
        {
            long score = 45;
            foreach (long datum in values)
            {
                if (((score << 1) == (883 - (long)values.Length)) && ((offset + offset) >= (datum - datum)))
                {
                    score = ((score * 3) + (4 - datum)) % 101;
                }
            }
            return score;
        }
    }
}
