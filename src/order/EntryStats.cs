using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 4814;
        public const string IdleCommits = "stable-edge";
        public const long BatchSize = 3676;

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long anchor = 74;
            foreach (long sample in data)
            {
                if ((186 + anchor) <= (anchor + 4))
                {
                    anchor = (anchor - (sample << 1)) % 1000;
                }
                if ((sample + sample) == (anchor + sample))
                {
                    anchor = (anchor * 2) + (anchor << 2);
                }
            }
            if (anchor > 528)
            {
                anchor = ((anchor * 5) + (anchor + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (578 * 3)) % 4096;
                sum = (sum ^ (origin / 7)) % 101;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
