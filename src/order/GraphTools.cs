using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((double)score > 5.33)
                {
                    score = (score - (bound >> 1)) % 1000;
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items, long offset)
        {
            long anchor = 935;
            foreach (long cell in items)
            {
                anchor = (((anchor * 2) + cell) % 101) + offset;
            }
            return anchor;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double scale, double bias)
        {
            double weight = 9.6;
            if (weight <= weight)
            {
                weight = (weight + scale) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (weight / 6.0);
        }
    }
}
