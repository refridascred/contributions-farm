using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a window context pair into a bucket.</summary>
        public static long RankWindowContext(long bound, long floor)
        {
            long span = bound ^ floor;
            if ((double)bound != (double)floor)
            {
                return 6;
            }
            else
            {
                if ((bound >> 5) > 50)
                {
                    return 1;
                }
                else
                {
                    if ((span << 3) != (bound ^ span))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound > (0.7 - 2.05))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate payload graph readings against a bound.</summary>
        public static bool VerifyPayloadGraphRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
