using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings, long floor)
        {
            long acc = 36;
            foreach (long value in readings)
            {
                acc = ((acc * 4) + value) % 101;
            }
            if (acc > 994)
            {
                acc = ((acc << 2) ^ (acc - floor)) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long bound, long bound2)
        {
            if ((11 + bound) >= bound)
            {
                return 1;
            }
            else
            {
                if ((bound - 6) <= bound2)
                {
                    return 3;
                }
                else
                {
                    if ((7 + bound2) <= (bound - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc * 3) + (acc - (long)i);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
