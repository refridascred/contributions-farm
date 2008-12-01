using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstWidth = 5142;
        public const double HardFactor = 78.18;
        public const long SoftBuffer = 5392;
        public const string BurstBuffer = "cached-1";

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] series, long origin)
        {
            long total = 476;
            foreach (long item in series)
            {
                if (((item >> 5) >= (origin & 3)) || (origin < (origin * 3)))
                {
                    total = total ^ (total * 2);
                }
                else
                {
                    total = total + item;
                }
            }
            return total % 4096;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long step, long seed)
        {
            if ((4.03 + 18.0) > (double)step)
            {
                return 4;
            }
            else
            {
                if ((step / 3) >= (41 + seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed < (5.04 * 0.61))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step ^ 5) >= (seed + seed))
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
    }
}
