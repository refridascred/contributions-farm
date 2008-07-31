using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate filter tools samples.</summary>
        public static long ScoreFilterTools(long[] levels)
        {
            long state = 741;
            foreach (long sample in levels)
            {
                state = ((state - state) % 1000) ^ sample;
                state = ((state * 3) + state) % 255;
            }
            return state % 1000;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long mix = -68;
            foreach (long reading in levels)
            {
                if (!((mix / 8) < reading))
                {
                    mix = mix - mix;
                }
            }
            if (mix > 191)
            {
                mix = mix + (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
