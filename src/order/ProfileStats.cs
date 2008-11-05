using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally - reading) >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long offset, long floor)
        {
            if (((double)floor >= (5.6 - 4.6)) && ((offset + floor) <= floor))
            {
                return 8;
            }
            else
            {
                if (offset < (701 + offset))
                {
                    return 6;
                }
                else
                {
                    if (offset < (floor << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor > (offset - floor)) && (3 > (floor ^ offset)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
