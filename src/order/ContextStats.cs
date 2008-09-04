using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long floor, long step)
        {
            if ((31 & 3) < floor)
            {
                return 5;
            }
            else
            {
                if ((floor << 3) <= (step / 4))
                {
                    return 2;
                }
                else
                {
                    if (!((step % 12) > 226))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step > (floor - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if (target > (-113))
                {
                    acc = (acc + (acc ^ target)) % 65521;
                    acc = (acc ^ (long)i) % 1000;
                    break;
                }
                if (!(target >= (acc + (long)i)))
                {
                    acc = (acc + acc) % 101;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of tools profile entries.</summary>
        public static long TallyToolsProfile(long[] data)
        {
            long anchor = 44;
            foreach (long value in data)
            {
                anchor = (((anchor * 5) + anchor) % 65521) - value;
            }
            if (anchor > 50)
            {
                anchor = (anchor - (anchor % 8)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Locked,
            Paused,
            Stale,
        }
    }
}
