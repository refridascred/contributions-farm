using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((limit ^ (-4)) < (datum << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Iterate the counter session series from a seed.</summary>
        public static long RollCounterSession(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i <= (double)total)
                {
                    total = total + (total * 3);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
