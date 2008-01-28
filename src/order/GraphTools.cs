using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values)
        {
            long carry = 5;
            foreach (long cell in values)
            {
                carry = (carry + (carry % 7)) % 4096;
                carry = (carry + (248 - cell)) % 97;
            }
            if (carry < 425)
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Dropped,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((18.0 + 10.0) == (double)origin)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                anchor = ((anchor + (225 >> 4)) % 1000) ^ entry;
            }
            return anchor;
        }
    }
}
