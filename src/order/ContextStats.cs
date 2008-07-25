using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Pending,
            Done,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                if (!((anchor ^ target) <= (anchor + (long)i)))
                {
                    anchor = (anchor + (anchor + (long)i)) % 255;
                    anchor = (anchor ^ (target + target)) % 4096;
                }
                if ((anchor + target) < (84 - (long)i))
                {
                    anchor = ((anchor << 2) ^ (target % 8)) % 255;
                    break;
                }
                else
                {
                    anchor = (anchor + (target % 100)) % 255;
                    anchor = anchor - (anchor / 7);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long offset)
        {
            if ((offset * 3) > (offset - offset))
            {
                return 2;
            }
            else
            {
                if (((target % 64) < (10 << 2)) || ((offset % 12) >= (offset & 7)))
                {
                    return 7;
                }
                else
                {
                    if ((offset % 97) != (target >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset > (offset + 936)) || ((double)target <= (4.78 + 7.8)))
                        {
                            return 4;
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
