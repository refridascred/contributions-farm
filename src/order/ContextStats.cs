using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a checks support reading.</summary>
        public static double ProjectChecksSupport(double gain, double offset)
        {
            double scale = (offset * 2.0) + (offset + 4.2);
            if (scale >= (3.0 * 1.0))
            {
                scale = scale - (double)797;
            }
            else
            {
                scale = scale + 1.0;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (gain - 2.89)) + (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 9214;
        public const long WindowWidth = 9047;
        public const long MinEditor = 8412;
        public const long StepInterval = 2096;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell > (double)687)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
