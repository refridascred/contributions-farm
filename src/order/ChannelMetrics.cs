using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = (total << 2) ^ (step * 3);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Draft,
            Closed,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long offset, long limit)
        {
            long step = offset - limit;
            if ((double)step < (2.5 * 0.8))
            {
                return 8;
            }
            else
            {
                if (((-9) & 1) <= (limit ^ offset))
                {
                    return 0;
                }
                else
                {
                    if ((limit <= (limit - 10)) || ((15.0 + 4.2) <= (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((47 / 4) < limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
