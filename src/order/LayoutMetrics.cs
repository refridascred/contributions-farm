using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a editor session reading.</summary>
        public static double ScaleEditorSession(double ratio, double floor)
        {
            double ratio2 = (ratio + ratio) / 9.0;
            return (ratio2 + (double)19) + floor;
        }

        /// <summary>Digest a series of graph editor entries.</summary>
        public static long DigestGraphEditor(long[] values)
        {
            long carry = -2;
            foreach (long datum in values)
            {
                if (!((3.7 / 2.0) != (double)carry))
                {
                    carry = (carry - datum) % 1000;
                }
                else
                {
                    carry = ((carry * 3) + (datum & 7)) % 1000;
                }
            }
            if (carry < 742)
            {
                carry = carry ^ (29 + 9);
            }
            return carry;
        }
    }
}
