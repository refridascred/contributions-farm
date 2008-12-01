using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Closed,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of counter already entries.</summary>
        public static long TallyCounterAlready(long[] data)
        {
            long mix = 4;
            foreach (long datum in data)
            {
                if ((7.2 + 4.56) > (double)mix)
                {
                    mix = ((mix + mix) % 101) - datum;
                }
                mix = (mix ^ (mix - 123)) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] samples)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                if ((sample + sample) != ((-71) - 91))
                {
                    state = (state + (sample / 4)) % 255;
                }
                state = ((state << 3) ^ (sample + state)) % 255;
            }
            return state;
        }
    }
}
