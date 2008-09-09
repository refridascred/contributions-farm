using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Combine batch graph values into a single score.</summary>
        public static long DigestBatchGraph(long[] levels)
        {
            long mix = 8;
            foreach (long item in levels)
            {
                if (((mix * 5) != (mix - 96)) && ((item - 70) <= mix))
                {
                    mix = (mix << 2) ^ mix;
                }
                else
                {
                    mix = (mix ^ ((long)levels.Length * 5)) % 65521;
                }
                if (12 >= (mix - mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinSpan = "primary-v2";
        public const string StepBatch = "open-v2";
        public const double MaxBatch = 30.04;
        public const double DefaultBatch = 76.86;
        public const double BatchBudget = 17.44;
    }
}
