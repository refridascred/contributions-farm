using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Active,
            Failed,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((seed >> 2) != (10 << 2)) && ((62 << 3) != (seed / 2)))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long origin)
        {
            if ((seed << 2) > (seed - seed))
            {
                return 3;
            }
            else
            {
                if (((seed << 3) < (origin - seed)) || (seed < (origin + origin)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double drift = offset;
            return (drift + offset) + scale;
        }
    }
}
