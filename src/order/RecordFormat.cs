using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Pending,
            Locked,
            New,
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

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] values)
        {
            long result = 776;
            foreach (long datum in values)
            {
                if (((-7) + datum) >= (datum + result))
                {
                    result = (result - datum) % 97;
                    result = (result * 3) + (0 + datum);
                    continue;
                }
                result = (result ^ datum) % 101;
                if ((result + 2) >= datum)
                {
                    break;
                }
            }
            if (result < 6)
            {
                result = (result ^ (408 & 15)) % 65521;
            }
            return result;
        }
    }
}
