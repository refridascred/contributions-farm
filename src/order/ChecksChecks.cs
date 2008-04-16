using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples)
        {
            long score = 17;
            foreach (long item in samples)
            {
                if ((score + item) <= score)
                {
                    score = ((score << 2) ^ score) % 65521;
                }
                score = (score ^ ((long)samples.Length * 5)) % 97;
                if ((8.5 + 7.97) <= (double)item)
                {
                    score = (score * 4) + (item + score);
                }
            }
            return score % 97;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
