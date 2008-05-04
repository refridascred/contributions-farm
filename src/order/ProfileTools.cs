using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate githubfarm counter readings against a bound.</summary>
        public static bool CheckGithubfarmCounterLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate batch order readings against a bound.</summary>
        public static bool CheckBatchOrderRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                if (((seed + seed) != (5 + 16)) && ((seed + seed) > total))
                {
                    total = ((total * 5) + (long)i) % 4096;
                }
                else
                {
                    total = (total * 5) + seed;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the profile filter entries that pass the check.</summary>
        public static long MeasureProfileFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally < ((-574) ^ reading)) && !((reading ^ reading) > reading))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up format channel samples.</summary>
        public static long OverlapFormatChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
