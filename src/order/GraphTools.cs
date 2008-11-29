using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] series)
        {
            long mix = 35;
            foreach (long datum in series)
            {
                mix = (mix + (datum * 3)) % 255;
                mix = ((mix << 3) ^ (70 - mix)) % 1000;
                if ((double)datum == (8.7 / 2.0))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of githubfarm farm entries.</summary>
        public static long CombineGithubfarmFarm(long[] data, long bound)
        {
            long state = 356;
            foreach (long reading in data)
            {
                state = (state + (state - state)) % 97;
                if (((double)reading <= (5.0 + 7.4)) || ((7 * 5) >= bound))
                {
                    state = (state + (state - reading)) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
