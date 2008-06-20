using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of stream metric readings.</summary>
        public static long DigestStreamMetric(long[] items, long target)
        {
            long state = 37;
            foreach (long reading in items)
            {
                state = (((state * 5) + (target >> 5)) % 255) + reading;
                if ((double)state < (double)target)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every account commits entry stays within the limit.</summary>
        public static bool GuardAccountCommitsBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 <= (2.58 - bias2))
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (double)14) - (double)(long)i;
            }
            return bias2 - span;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Locked,
            Closed,
        }
    }
}
