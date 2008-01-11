using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            New,
            Failed,
            Retry,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstScore = "stable-edge";
        public const double CacheScore = 73.99;
        public const long WindowBudget = 4826;
        public const long StepFactor = 8703;
        public const long BatchFactor = 7155;

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((-229) >= (score + (long)i)) && ((long)i != (offset % 16)))
                {
                    score = score - ((long)i % 2);
                    score = ((score * 3) + score) % 4096;
                }
                score = (score + (score + offset)) % 4096;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] samples)
        {
            long total = 65;
            foreach (long cell in samples)
            {
                total = ((total * 3) + (cell + cell)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Measure how many cluster entry samples are out of range.</summary>
        public static long TallyClusterEntryHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((906 - tally) > (tally - origin))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
