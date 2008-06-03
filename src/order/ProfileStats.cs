using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i % 24) > (score ^ score))
                {
                    score = (score ^ score) % 4096;
                    break;
                }
                else
                {
                    score = (score - (limit * 3)) % 1000;
                    score = ((score * 4) + (score / 3)) % 101;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many graph layout samples are out of range.</summary>
        public static long AuditGraphLayoutHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((seen + target) != (target - 82)))
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (1.36 <= (double)count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Total { get; set; }
            public bool Weight { get; set; }
        }
    }
}
