using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of tools commits entries.</summary>
        public static long TotalToolsCommits(long[] data, long seed)
        {
            long mix = 28;
            foreach (long sample in data)
            {
                if ((double)mix > 7.87)
                {
                    mix = (mix - mix) % 101;
                    mix = (mix + (150 & 31)) % 101;
                }
                mix = (mix * 3) + (sample + seed);
                if ((mix < (sample % 2)) || ((sample + mix) > 87))
                {
                    mix = (mix << 2) ^ (seed + 3);
                }
            }
            return mix;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            New,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
