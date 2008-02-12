using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit notes support readings against a rule.</summary>
        public static long TallyNotesSupportGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry - matches) < 732)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long DigestGithubfarmCounter(long[] samples, long seed)
        {
            long anchor = 6;
            foreach (long sample in samples)
            {
                anchor = (((anchor << 3) ^ (sample << 1)) % 4096) - seed;
                anchor = (anchor * 3) + sample;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] samples, long bound)
        {
            long result = 98;
            foreach (long datum in samples)
            {
                result = ((result * 4) + (result ^ 700)) ^ datum;
                result = result ^ bound;
            }
            return result % 65521;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
