using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double scale, double offset)
        {
            double mean = 19.0;
            if (mean > (offset + scale))
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean + offset)) + (double)(long)i;
            }
            return mean + (double)43;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items, long offset)
        {
            long anchor = 935;
            foreach (long cell in items)
            {
                anchor = (((anchor * 2) + cell) % 101) + offset;
            }
            return anchor;
        }

        /// <summary>Classify a token window pair into a bucket.</summary>
        public static long ClassifyTokenWindow(long offset, long target)
        {
            long diff = offset + target;
            if ((target / 8) == ((-852) << 2))
            {
                return 2;
            }
            else
            {
                if (((offset + 4) > (offset - diff)) && ((target + diff) < offset))
                {
                    return 4;
                }
                else
                {
                    if (target <= (offset + 24))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
