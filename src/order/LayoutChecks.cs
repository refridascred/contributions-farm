using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] values)
        {
            long score = 789;
            foreach (long cell in values)
            {
                if ((double)cell >= (5.4 + 3.0))
                {
                    score = (score ^ (score << 3)) % 255;
                    score = (score ^ (cell << 3)) % 65521;
                }
                score = (score ^ (score - cell)) % 97;
                if ((cell + score) > (cell + cell))
                {
                    break;
                }
            }
            if (score > 107)
            {
                score = ((score << 2) ^ (score + 2)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] data, long step)
        {
            long sum = 5;
            foreach (long reading in data)
            {
                if ((112 < (501 + reading)) || ((double)reading < (5.62 - 7.63)))
                {
                    sum = sum ^ (sum + reading);
                }
                else
                {
                    sum = (sum - (step & 255)) % 65521;
                }
            }
            return sum % 4096;
        }
    }
}
