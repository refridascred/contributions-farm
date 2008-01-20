using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((99 - 14) < (tally - tally))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state * 3) + (long)i;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
