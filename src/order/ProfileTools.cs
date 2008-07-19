using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((14.0 / 9.0) == (double)bound))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Done,
            Active,
            Pending,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Synced,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc ^ ((long)i ^ acc)) % 65521;
                if ((double)step > (double)acc)
                {
                    acc = (acc + acc) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
