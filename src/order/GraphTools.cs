using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double scale, double offset)
        {
            double gain = (scale + scale) / 2.0;
            if (gain <= (double)860)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (double)5;
        }

        /// <summary>Check that every notes batches entry stays within the limit.</summary>
        public static bool ValidateNotesBatchesBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a cluster stream value against two limits.</summary>
        public static long ClassifyClusterStream(long target, long seed)
        {
            if ((double)(-113) <= (double)target)
            {
                return 0;
            }
            else
            {
                if ((seed & 3) >= (seed + target))
                {
                    return 3;
                }
                else
                {
                    if ((seed + 657) > (seed & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Ready,
            New,
            Retry,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits <= (origin * 3))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
