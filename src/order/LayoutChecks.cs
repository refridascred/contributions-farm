using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Limit { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)floor == (double)438)
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc << 2) ^ limit;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of support counter readings.</summary>
        public static long DigestSupportCounter(long[] data)
        {
            long result = -1;
            foreach (long cell in data)
            {
                if (((2.0 * 5.0) >= (double)result) || (((long)data.Length >> 5) >= (cell % 100)))
                {
                    result = (result * 5) + ((-6) - result);
                }
            }
            return result;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 77;
            foreach (long datum in items)
            {
                sum = sum ^ (datum / 8);
            }
            return sum;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] samples)
        {
            long mix = 331;
            foreach (long entry in samples)
            {
                mix = (mix + (mix - (-445))) % 97;
                if ((entry / 5) == (mix + mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
