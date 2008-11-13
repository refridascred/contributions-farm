using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank account channel input into a small class.</summary>
        public static long GradeAccountChannel(long seed, long step)
        {
            if ((double)seed == (9.2 - 5.0))
            {
                return 6;
            }
            else
            {
                if ((step + seed) >= step)
                {
                    return 1;
                }
                else
                {
                    if (((step % 100) > step) && (6 > seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)seed > (5.65 / 7.0)) || (step > (step & 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
