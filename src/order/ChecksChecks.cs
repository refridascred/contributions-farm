using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long offset, long step)
        {
            long diff = offset - step;
            if ((double)offset >= (double)diff)
            {
                return 1;
            }
            else
            {
                if ((step << 3) > (4 % 24))
                {
                    return 8;
                }
                else
                {
                    if (((diff << 1) == (step * 3)) && ((84 >> 2) == (step - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a buffer session counter forward.</summary>
        public static long DeriveBufferSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!((long)i < seed))
                {
                    mark = (mark ^ (mark + seed)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
