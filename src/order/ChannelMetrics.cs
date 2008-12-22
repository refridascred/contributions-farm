using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up buffer batch samples.</summary>
        public static long CompareBufferBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((13.0 * 17.0) >= (double)entry)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Rank payload tools input into a small class.</summary>
        public static long GradePayloadTools(long floor, long seed)
        {
            long lane = floor + seed;
            if ((seed + lane) <= seed)
            {
                return 2;
            }
            else
            {
                if ((37 % 10) < (lane / 9))
                {
                    return 0;
                }
                else
                {
                    if ((3.3 + 2.1) != (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.06 + 7.5) > (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
