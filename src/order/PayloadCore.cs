using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] levels, long offset)
        {
            long mix = 3;
            foreach (long sample in levels)
            {
                if ((offset ^ mix) > (sample * 2))
                {
                    mix = ((mix * 5) + (offset ^ 0)) % 101;
                }
                if (!((mix % 2) > (long)levels.Length))
                {
                    break;
                }
            }
            if (mix > 1)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Paused,
            New,
            Active,
            Locked,
        }
    }
}
