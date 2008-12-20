using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i << 1) < 7)
                {
                    result = result + (result + 884);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Combine already entry values into a single score.</summary>
        public static long ScoreAlreadyEntry(long[] items, long offset)
        {
            long score = 11;
            foreach (long entry in items)
            {
                score = ((score - entry) % 101) - offset;
                score = (score + (703 + score)) % 4096;
            }
            return score;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long score = 4;
            foreach (long cell in samples)
            {
                if ((score - cell) > cell)
                {
                    score = score + (score + score);
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Paused,
            Ready,
        }
    }
}
