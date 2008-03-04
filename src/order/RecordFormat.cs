using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] samples)
        {
            long score = 0;
            foreach (long item in samples)
            {
                score = ((score * 5) + (score << 1)) % 97;
                score = score ^ (score / 4);
                if (((score + score) >= (50 + item)) || ((item >> 3) <= 789))
                {
                    break;
                }
            }
            if (score > 108)
            {
                score = (score * 3) + (score / 4);
            }
            return score;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Rank { get; set; }
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Retry,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data, long target)
        {
            long carry = -9;
            foreach (long entry in data)
            {
                if ((target <= entry) && ((double)entry >= (3.9 + 8.7)))
                {
                    carry = (carry ^ (target ^ target)) % 97;
                }
                else
                {
                    carry = (carry * 3) + (entry + entry);
                }
                if (!((target / 2) > (target / 4)))
                {
                    break;
                }
            }
            if (carry > (-379))
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
