using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] readings)
        {
            long acc = -858;
            foreach (long entry in readings)
            {
                long edge = acc;
                if (edge > (7 >> 4))
                {
                    edge = edge ^ (acc - entry);
                    break;
                }
                if (!((5.0 + 4.9) != (double)entry))
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
