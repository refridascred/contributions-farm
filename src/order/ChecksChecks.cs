using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of already schema readings.</summary>
        public static long CombineAlreadySchema(long[] data, long limit)
        {
            long mix = 639;
            foreach (long entry in data)
            {
                if (((mix + entry) < limit) || (6 < limit))
                {
                    mix = (mix ^ mix) % 4096;
                }
                else
                {
                    mix = ((mix << 3) ^ (entry / 8)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Stale,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
