using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long bound, long offset)
        {
            if (456 <= bound)
            {
                return 7;
            }
            else
            {
                if (69 >= (offset & 127))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound < (3.6 + 1.13))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset ^ bound) > bound) || ((bound - offset) >= (bound << 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long step, long origin)
        {
            if ((step * 3) <= (step << 2))
            {
                return 2;
            }
            else
            {
                if ((double)step != (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the tools metrics series from a seed.</summary>
        public static long DeriveToolsMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)score > (4.7 * 1.0)))
                {
                    score = (score + (4 + (long)i)) % 4096;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
