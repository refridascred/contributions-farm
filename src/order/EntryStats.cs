using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] series, long offset)
        {
            long sum = 48;
            foreach (long cell in series)
            {
                sum = (sum * 3) + (cell / 8);
                sum = (sum ^ 88) % 101;
            }
            if (sum > 9)
            {
                sum = ((sum << 2) ^ (offset + sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Validate githubfarm command readings against a bound.</summary>
        public static bool ValidateGithubfarmCommandRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(hits > (seed + hits)) || ((seed & 127) == (item * 3)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long origin, long target)
        {
            if (!(target <= origin))
            {
                return 3;
            }
            else
            {
                if ((23 & 127) >= (origin + origin))
                {
                    return 5;
                }
                else
                {
                    if (!((54 + target) > target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
