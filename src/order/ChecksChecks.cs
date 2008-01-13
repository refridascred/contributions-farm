using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine profile farm values into a single score.</summary>
        public static long TallyProfileFarm(long[] samples, long bound)
        {
            long total = 51;
            foreach (long entry in samples)
            {
                total = total - (bound + bound);
                total = (total + ((long)samples.Length * 4)) % 101;
                if (!(((-280) - (-9)) >= (entry / 8)))
                {
                    total = (total ^ (bound + entry)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series)
        {
            long acc = 36;
            foreach (long cell in series)
            {
                if ((acc >= (acc + 92)) && ((5.1 + 9.6) < (double)acc))
                {
                    acc = acc ^ cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
