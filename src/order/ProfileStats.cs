using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a payload tools value against two limits.</summary>
        public static long ClassifyPayloadTools(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if (((double)offset2 > (double)offset) || (offset < offset3))
            {
                return 6;
            }
            else
            {
                if (offset >= (offset3 + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset2 * 2) != (205 / 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset2 >> 2) < (offset >> 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                if (18 < (mix + entry))
                {
                    mix = (mix - (mix + mix)) % 1000;
                }
                if ((entry << 2) >= (entry / 2))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}
