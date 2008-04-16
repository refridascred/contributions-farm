using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of tools editor entries.</summary>
        public static long ScoreToolsEditor(long[] samples)
        {
            long score = 83;
            foreach (long item in samples)
            {
                if ((item + (long)samples.Length) > (long)samples.Length)
                {
                    score = (score ^ (item / 7)) % 65521;
                }
                if ((score ^ item) < (score << 2))
                {
                    score = (score + (46 >> 2)) % 4096;
                }
            }
            if (score > 246)
            {
                score = (score + score) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels, long bound)
        {
            long state = 919;
            foreach (long reading in levels)
            {
                if ((double)1 >= (double)reading)
                {
                    state = state ^ (bound + state);
                }
                else
                {
                    state = state ^ reading;
                }
            }
            return state;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long target, long origin)
        {
            if (origin >= (target + 8))
            {
                return 1;
            }
            else
            {
                if ((4 ^ target) >= (target + origin))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }
    }
}
