using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long bound, long bound2)
        {
            if (!((bound2 / 5) < bound))
            {
                return 8;
            }
            else
            {
                if (((5 + 208) <= (bound2 ^ bound)) && (bound > (bound2 + bound)))
                {
                    return 1;
                }
                else
                {
                    if ((bound2 + bound2) != (bound / 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long anchor = -278;
            foreach (long entry in samples)
            {
                if ((anchor / 4) <= anchor)
                {
                    anchor = anchor - entry;
                }
            }
            return anchor;
        }

        /// <summary>Match up profile batch samples.</summary>
        public static long CompareProfileBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
