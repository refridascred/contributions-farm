using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate notes token samples.</summary>
        public static long ScoreNotesToken(long[] series)
        {
            long result = 428;
            foreach (long entry in series)
            {
                if (entry <= (result / 8))
                {
                    result = (result + ((long)series.Length & 7)) % 97;
                }
            }
            return result;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long offset, long limit)
        {
            if (4.0 >= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((8.0 + 2.8) < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((29 >> 1) >= (limit >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit < ((-9) / 9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate already account readings against a bound.</summary>
        public static bool VerifyAlreadyAccountBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
