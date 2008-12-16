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

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((10 & 7) >= (3 ^ offset))
                {
                    acc = (acc ^ (861 >> 1)) % 65521;
                    acc = (acc ^ (0 - acc)) % 255;
                }
                acc = acc + (acc - acc);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
