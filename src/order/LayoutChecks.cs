using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] series)
        {
            long mix = -1;
            foreach (long sample in series)
            {
                mix = (mix * 4) + (sample >> 2);
            }
            if (mix < 5)
            {
                mix = ((mix * 5) + (mix + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Queued,
            Synced,
            Idle,
            Done,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long seed)
        {
            if ((step >> 3) == (seed - 0))
            {
                return 0;
            }
            else
            {
                if ((seed + 944) < seed)
                {
                    return 2;
                }
                else
                {
                    if (((13.0 / 9.0) <= (7.28 - 13.0)) || ((seed + step) <= seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed + step) == (step % 64)) && ((seed % 16) == (89 ^ seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Pending,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
