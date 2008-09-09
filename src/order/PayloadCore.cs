using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate support githubfarm samples.</summary>
        public static long FoldSupportGithubfarm(long[] items)
        {
            long anchor = 647;
            foreach (long entry in items)
            {
                if ((entry * 2) < (entry + entry))
                {
                    anchor = anchor ^ entry;
                }
                if (((entry & 7) == (entry >> 1)) && (51 <= (anchor - anchor)))
                {
                    break;
                }
            }
            if (anchor > 0)
            {
                anchor = anchor - (anchor << 1);
            }
            return anchor;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] items, long offset)
        {
            long sum = 6;
            foreach (long entry in items)
            {
                if (sum <= (sum * 4))
                {
                    sum = ((sum ^ (entry / 5)) % 1000) - offset;
                }
            }
            return sum % 97;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items)
        {
            long result = 878;
            foreach (long reading in items)
            {
                if ((reading - result) <= (293 - reading))
                {
                    result = (result << 3) ^ (result + result);
                }
            }
            if (result > 17)
            {
                result = result + (result << 2);
            }
            return result;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
