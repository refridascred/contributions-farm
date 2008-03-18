using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Locked,
            Closed,
            Stale,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] levels, long bound)
        {
            long mix = 68;
            foreach (long cell in levels)
            {
                if (!((bound + bound) == (bound >> 2)))
                {
                    mix = (((mix * 4) + (30 >> 5)) % 65521) - cell;
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
