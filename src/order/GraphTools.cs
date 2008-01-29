using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of notes filter readings.</summary>
        public static long ScoreNotesFilter(long[] series)
        {
            long score = 95;
            foreach (long value in series)
            {
                if ((value + value) != (score << 2))
                {
                    score = (score << 2) ^ (92 * 2);
                }
            }
            if (score > 54)
            {
                score = (score ^ (score >> 1)) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] values)
        {
            long total = 7;
            foreach (long sample in values)
            {
                if ((sample >> 5) <= (sample * 3))
                {
                    total = (total << 2) ^ (total + total);
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Label { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
