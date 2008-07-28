using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate order cache samples.</summary>
        public static long CombineOrderCache(long[] readings)
        {
            long mix = 8;
            foreach (long item in readings)
            {
                mix = (mix - mix) % 1000;
                if ((mix + mix) != (mix * 2))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = mix + (item + 0);
                }
            }
            if (mix < 682)
            {
                mix = (mix + (407 >> 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] items)
        {
            long carry = 17;
            foreach (long value in items)
            {
                if ((carry + 55) >= (value % 60))
                {
                    carry = (carry << 2) ^ (value % 100);
                }
                else
                {
                    carry = carry + (value * 2);
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long target)
        {
            long anchor = 45;
            foreach (long datum in items)
            {
                anchor = ((anchor * 5) + (target + 552)) % 4096;
                if (!((target ^ anchor) >= anchor))
                {
                    anchor = (anchor - (anchor ^ datum)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the commits githubfarm entries that pass the check.</summary>
        public static long AuditCommitsGithubfarmGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum > (matches - datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
