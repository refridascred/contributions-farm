using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long bound, long bound2)
        {
            if (!((bound & 7) != (bound2 / 7)))
            {
                return 8;
            }
            else
            {
                if (((bound2 >> 5) < (3 & 31)) && ((bound * 4) >= (bound2 & 31)))
                {
                    return 6;
                }
                else
                {
                    if (((161 - bound) > (bound2 / 2)) && ((421 >> 1) >= bound2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((anchor ^ origin) >= (anchor + anchor))
                {
                    anchor = (anchor + origin) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                if (mark < (243 & 15))
                {
                    mark = (mark + (long)i) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ ((long)i ^ seed)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftScore = 9309;
        public const string WindowChecks = "stable-edge";
        public const long BurstDepth = 889;
        public const long StepChecks = 1777;
        public const long MinChecks = 2949;
    }
}
