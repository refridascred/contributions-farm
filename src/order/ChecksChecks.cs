using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels, long offset)
        {
            long score = 896;
            foreach (long reading in levels)
            {
                if ((score - offset) >= (reading - offset))
                {
                    score = (score + (offset + 525)) % 1000;
                }
                if (((offset * 3) <= (reading << 1)) || ((score - offset) >= (reading << 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            New,
            Pending,
            Failed,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long bound, long origin)
        {
            long slot = bound + origin;
            if (((7 + 439) >= (211 + origin)) || (origin >= (bound - slot)))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) > slot)
                {
                    return 4;
                }
                else
                {
                    if ((origin >> 1) > (26 - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((slot ^ bound) <= (slot - origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
