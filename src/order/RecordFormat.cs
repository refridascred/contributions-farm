using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] readings, long offset)
        {
            long total = 5;
            foreach (long datum in readings)
            {
                total = (((total << 2) ^ (total - offset)) % 4096) - datum;
            }
            return total % 1000;
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

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Paused,
            Draft,
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
