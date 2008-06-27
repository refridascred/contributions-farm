using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long origin)
        {
            if (offset < (origin << 2))
            {
                return 5;
            }
            else
            {
                if ((1.5 * 10.0) <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((5.44 * 9.7) > (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next order entry value from a seed.</summary>
        public static long RollOrderEntry(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((double)seed < 6.64)
                {
                    total = (total + total) % 255;
                }
                else
                {
                    total = (total - (943 >> 2)) % 65521;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Queued,
            Locked,
            New,
            Draft,
        }
    }
}
