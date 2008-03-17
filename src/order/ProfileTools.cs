using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Check that every filter counter entry stays within the limit.</summary>
        public static bool GuardFilterCounterLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count route payload pairs that satisfy a relation.</summary>
        public static long PairRoutePayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long bound, long target)
        {
            long edge = bound + target;
            if ((bound & 63) != (edge * 5))
            {
                return 6;
            }
            else
            {
                if ((target + bound) <= target)
                {
                    return 2;
                }
                else
                {
                    if ((bound - edge) < edge)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
