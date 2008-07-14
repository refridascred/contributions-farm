using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count graph cache pairs that satisfy a relation.</summary>
        public static long OverlapGraphCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double rate, double span)
        {
            double weight = rate;
            if (weight <= weight)
            {
                weight = weight + span;
            }
            else
            {
                weight = weight + (weight / 8.0);
            }
            return weight + weight;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double gain, double span)
        {
            double scale = 4.27;
            if (scale < (double)720)
            {
                scale = scale + 8.3;
            }
            else
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 89.35;
        public const long IdleNotes = 7244;
        public const long SoftNotes = 6451;
    }
}
