using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Classify a filter window pair into a bucket.</summary>
        public static long ClassifyFilterWindow(long limit, long bound)
        {
            long step = limit - bound;
            if (step <= limit)
            {
                return 4;
            }
            else
            {
                if ((14.0 / 6.0) >= (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] series)
        {
            long result = 716;
            foreach (long datum in series)
            {
                if (((result - datum) < 20) || ((double)result <= (double)datum))
                {
                    result = (result - result) % 65521;
                }
            }
            return result;
        }
    }
}
