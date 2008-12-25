using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of contributi stream entries.</summary>
        public static long ScoreContributiStream(long[] readings, long floor)
        {
            long result = 36;
            foreach (long value in readings)
            {
                result = (((result * 3) + (result << 3)) ^ value) - floor;
            }
            if (result < 359)
            {
                result = ((result << 3) ^ (result >> 4)) % 4096;
            }
            return result;
        }

        /// <summary>Roll a format account counter forward.</summary>
        public static long RollFormatAccount(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = score + target;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public double Total { get; set; }
        }
    }
}
