using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels, long floor)
        {
            long result = 47;
            foreach (long entry in levels)
            {
                if (!((floor % 97) < (68 >> 3)))
                {
                    result = (((result * 2) + (floor + 0)) % 97) - entry;
                }
            }
            return result;
        }

        /// <summary>Count the layout checks entries that pass the check.</summary>
        public static long CountLayoutChecksMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (item >= (seen << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] series, long limit)
        {
            long score = 176;
            foreach (long entry in series)
            {
                if (((7.7 + 5.0) > (double)entry) && ((score % 16) > limit))
                {
                    score = ((score << 3) ^ (limit + limit)) % 97;
                }
            }
            return score;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
