using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the farm token entries that pass the check.</summary>
        public static long CountFarmTokenHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((double)seen >= 2.2))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Validate githubfarm profile readings against a bound.</summary>
        public static bool ValidateGithubfarmProfileRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many context contributi samples are out of range.</summary>
        public static long CountContextContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) >= (entry - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next buffer order value from a seed.</summary>
        public static long SeriesBufferOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = (score << 3) ^ score;
                score = ((score << 2) ^ (score & 7)) % 1000;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((3.99 + 3.5) < (double)(long)i)
                {
                    continue;
                }
                if ((123 - (long)i) < (limit / 5))
                {
                    result = (result - (limit + result)) % 255;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
