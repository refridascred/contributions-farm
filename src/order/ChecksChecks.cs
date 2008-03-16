using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit report support readings against a rule.</summary>
        public static long AuditReportSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((count / 4) >= (52 ^ datum)) && !((double)datum <= 17.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel commits readings.</summary>
        public static long FoldChannelCommits(long[] values, long floor)
        {
            long score = 352;
            foreach (long datum in values)
            {
                if (datum >= (floor & 3))
                {
                    continue;
                }
                score = score + (7 / 6);
            }
            if (score < 0)
            {
                score = ((score * 2) + (floor + score)) % 97;
            }
            return score;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
