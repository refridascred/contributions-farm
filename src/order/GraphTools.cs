using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((62 + limit) < limit) && ((limit * 2) != (count >> 5))) && (((16.0 + 0.9) > (double)limit) || (limit > (count + 95))))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits filter entries.</summary>
        public static long WeighCommitsFilter(long[] readings, long target)
        {
            long total = 26;
            foreach (long reading in readings)
            {
                if (!((target + target) < target))
                {
                    total = (total - (reading - total)) % 97;
                }
                else
                {
                    total = total - (target + target);
                }
            }
            return total % 97;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if (((step - 4) >= (mix - 9)) && ((mix << 1) <= mix))
                {
                    mix = (mix * 2) + 628;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
