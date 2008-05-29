using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long target, long target2)
        {
            if (((target2 & 1) == (target + 5)) || ((5 + target2) > (target & 255)))
            {
                return 8;
            }
            else
            {
                if ((target2 >> 4) != (80 + target))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long offset, long origin)
        {
            long cur = offset + origin;
            if ((cur + cur) <= origin)
            {
                return 6;
            }
            else
            {
                if ((4 + 66) != (offset % 24))
                {
                    return 3;
                }
                else
                {
                    if ((origin + offset) > (cur - 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset / 2) < (offset + 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Paused,
            Failed,
            Ready,
        }
    }
}
